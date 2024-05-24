using Application.IServices;
using Confluent.Kafka;
using Domain;
using Domain.ReqModel;
using Infrastructure.IRepository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace Application.Services
{
    public class ConsumerService: IConsumerService
    {
        private readonly IConsumer<Ignore, string> _consumer;

        private readonly ILogger<ConsumerService> _logger;

        private readonly IConsumerRepository _consumerRepository;
        CancellationTokenSource cts = new CancellationTokenSource();
		public ConsumerService(ILogger<ConsumerService> logger, IConsumerRepository consumerRepository)
        {
            _logger = logger;



            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "test-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            _consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            _consumer.Subscribe("declaration-topic");

            _consumerRepository =consumerRepository;

            Console.CancelKeyPress += (_, e) =>
            {
                e.Cancel = true; // prevent the process from terminating.
                cts.Cancel();
            };
        }

	
		public string StartConsuming()
        {
            //var totalChargesService = new TotalChargesService();

            try
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    var consumeResult = _consumer.Consume();
                    var json = JObject.Parse(consumeResult.Message.Value);

                    var email = json["email"].ToString();
                    var declarationId = (int)json["declarationGoodItems"][0]["declarationId"]; // Get declarationId from the first item
                    var declarationType = json["declarationType"].ToString();
                    var payerTin = (int)json["payerTin"];
                    var date = DateTime.Parse(json["date"].ToString());
                    var expectedDateOfDelivery = date.ToString("yyyy-MM-ddTHH:mm:ss");
                    var transportationMode = json["transportationMode"].ToString();

                    // Map Tin numbers to company names for consignee, consignor, and payer
                    var consigneeTin = (int)json["consigneeTIN"];
                    var consignorTin = (int)json["consignorTIN"];
                    var consigneeName = _consumerRepository.GetCOmpanyDetails().Where(x => x.TIN == Convert.ToInt64(consigneeTin)).Select(a => a.Name).FirstOrDefault(); 
                    var consignorName = _consumerRepository.GetCOmpanyDetails().Where(x => x.TIN == Convert.ToInt64(consignorTin)).Select(a => a.Name).FirstOrDefault();
                    var payerName = _consumerRepository.GetCOmpanyDetails().Where(x => x.TIN == Convert.ToInt64(payerTin)).Select(a => a.Name).FirstOrDefault();

                    var goodItems = json["declarationGoodItems"].Select(item => new GoodItem
                    {
                        Quantity = (int)item["quantity"],
                        MaterialType = item["materialType"].ToString(),
                        Price = (double)item["price"]
                    }).ToList();

                    //var totalCharges = totalChargesService.CalculateTotalCharges(goodItems);
                        double totalCharges = 0;

                        foreach (var item in goodItems)
                        {
                            double totalPrice = item.Price * item.Quantity;
                            double dutyCharges = Convert.ToDouble(_consumerRepository.MaterialCommodityMappings().Where(x => x.MaterialType == item.MaterialType).FirstOrDefault().DutyPercentage) * totalPrice;
                            totalCharges += dutyCharges;
                        //Save Good items 
                        _consumerRepository.SaveGoodItems(new ClsGoodsItem()
                        {
                            DeclarationID = declarationId,
                            Quantity = goodItems.Count,
                            DutyCharges = Convert.ToDecimal(dutyCharges),
                            CommodityCode= (_consumerRepository.MaterialCommodityMappings().Where(x => x.MaterialType == item.MaterialType).FirstOrDefault().CommodityCode).ToString(),
                        });

                    }
                   

                    var processedJson = new
                    {
                        email,
                        DeclarationType = declarationType,
                        payerTin,
                        importCountry = json["importCountry"].ToString(),
                        exportCountry = json["exportCountry"].ToString(),
                        consigneeTIN = consigneeTin,
                        consignorTIN = consignorTin,
                        date,
                        transportationMode,
                        declarationGoodItems = json["declarationGoodItems"].ToString()

                    };

                    //Save Declaration
                    #region Save data into database
                    var res = _consumerRepository.saveDeclaration(new ClsDeclaration()
                    {
                        //DeclarationId = declarationId,
                        DeclarationType = declarationType,
                        payerTin = payerTin,
                        consigneeTin = consigneeTin,
                        consignerTin = consignorTin,
                        ImportCountry = json["importCountry"].ToString(),
                        ExportCountry = json["exportCountry"].ToString(),
                        Date = Convert.ToDateTime(date),
                        transportationMode = transportationMode,
                        expectedDateOfDelivery = Convert.ToDateTime(date).AddDays(10),
                        totalCharges = Convert.ToDecimal(totalCharges),
                        CreatedOn = DateTime.Now
                    });
                    var processedJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(processedJson, Newtonsoft.Json.Formatting.Indented);
                    if (res > 0)
                    {
                        _consumerRepository.saveMessages(new ClsMessage()
                        {
                            delcaration = processedJsonString,
                            CreatedOn = DateTime.Now
                        });

                        var eventJson = new
                        {
                            email,
                            DeclarationId = declarationId,
                            DeclarationType = declarationType,
                            numberofdeclaration = json["declarationGoodItems"].Count(),
                            consigneeName,
                            consignorName,
                            payerName,
                            importCountry = json["importCountry"].ToString(),
                            exportCountry = json["exportCountry"].ToString(),
                            date,
                            expectedDateOfDelivery,
                            transportationMode,
                            totalcharges=Convert.ToDecimal(totalCharges),
                            GoodsItems=goodItems,
                        };
                        _consumerRepository.saveEvents(new ClsEvent()
                        {
                            events = processedJsonString,
                            CreatedOn = DateTime.Now
                        });
                    }

                    #endregion
                    return processedJsonString;
                }
            }
            catch (OperationCanceledException)
            {
                _consumer.Close();
                return null;
            }
            return null;
        }

		
		public void EndConsuming(IConsumer<Ignore, string> consumer)
        {
            try
            {
                // Close the consumer
                consumer.Close();
                Console.WriteLine("Consumer closed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while closing the consumer: {ex.Message}");
            }
            finally
            {
                // Additional cleanup logic if needed
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
