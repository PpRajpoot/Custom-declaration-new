using System;
using System.Linq;
using System.Threading;
using Confluent.Kafka;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TestConsumer
{
    class Program
    {
        static void Main(string[] args)
        {

            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "test-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("declaration-topic");

            CancellationTokenSource cts = new CancellationTokenSource();

            Console.CancelKeyPress += (_, e) =>
            {
                e.Cancel = true; // prevent the process from terminating.
                cts.Cancel();
            };

            try
            {
                while (true)
                {
                    var consumeResult = consumer.Consume(cts.Token);
                    var json = JObject.Parse(consumeResult.Message.Value);

                    var email = json["email"].ToString();
                    var declarationId = (int)json["DeclarationId"]; // Get declarationId from the first item
                    var declarationType = json["declarationType"].ToString();
                    var noOfDeclaration = json["numberofdeclaration"].ToString();
                    var consigneeName = json["consigneeName"].ToString();
                    var consignorName = json["consignorName"].ToString();
                    var payerName = json["payerName"].ToString();
                    var importCountry = json["importCountry"].ToString();
                    var exportCountry = json["exportCountry"].ToString();
                    var date = json["date"].ToString();
                    var expectedDateOfDelivery = json["expectedDateOfDelivery"].ToString();
                    var transportationMode = json["transportationMode"].ToString();
                    var totalcharges = json["totalcharges"].ToString();
                    var GoodsItems = json["GoodsItems"].ToString();

                    var processedJson = new
                    {
                        email,
                        declarationId,
                        declarationType,
                        noOfDeclaration,
                        consigneeName,
                        consignorName,
                        payerName,
                        importCountry,
                        exportCountry,
                        date,
                        expectedDateOfDelivery,
                        transportationMode,
                        totalcharges,
                        GoodsItems
                    };

                    var processedJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(processedJson, Newtonsoft.Json.Formatting.Indented);
                    Console.WriteLine(processedJsonString);
                }
            }
            catch (OperationCanceledException)
            {

                consumer.Close();
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
