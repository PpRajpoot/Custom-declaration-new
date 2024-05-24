using ApplicationProducer.IServices;
using ApplicationProducer.IServices;
using Confluent.Kafka;
using DomainProducer;
using Infrastructure.IRepository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;

namespace ApplicationProducer.Services
{
    public class ProducerService : IProducerService
    {
        private IProducerRepository _producerRepository;
        public ProducerService(IProducerRepository producerRepository) { 
        _producerRepository = producerRepository;
        }

        public async Task<string> StartProducing()
        {
                var config = new ProducerConfig
                {
                    BootstrapServers = "localhost:9092" // Update with your Kafka server details
                };

                using var producer = new ProducerBuilder<Null, string>(config).Build();
            var result = _producerRepository.GetEvent("");
            if(result!= null&&result.Count>0) {
               var  json=result.OrderByDescending(x=>x.CreatedOn).FirstOrDefault().events;
                var message = new Message<Null, string> { Value = json };

                var deliveryResult = await producer.ProduceAsync("declaration-topic", message);
                return $"Produced message to: {deliveryResult.TopicPartitionOffset}";
            }
        //        var json = @"{
        //        ""declarationType"":""Imports"",
        //        ""payerTin"":10003,
        //        ""email"":""anchal@gmail.com"",
        //        ""importCountry"":""Sweden"",
        //        ""exportCountry"":""India"",
        //        ""consigneeTIN"":10001,
        //        ""consignorTIN"":10002,
        //        ""date"":""2024-02-09T00:00:00"",
        //        ""transportationMode"":""byAir"",
        //        ""declarationGoodItems"":[
        //            {""goodItemId"":1,""quantity"":2,""materialType"":""Plastic"",""price"":2000.00,""declarationId"":6},
        //            {""goodItemId"":2,""quantity"":3,""materialType"":""Electronic"",""price"":5000.00,""declarationId"":6},
				    ////{""goodItemId"":3,""quantity"":3,""materialType"":""crude oil"",""price"":5000.00,""declarationId"":6}
        //        ]
        //    }";

                //var message = new Message<Null, string> { Value = json };

                //var deliveryResult = await producer.ProduceAsync("declaration-topic", message);
                
            return null;
        }
    }
}
