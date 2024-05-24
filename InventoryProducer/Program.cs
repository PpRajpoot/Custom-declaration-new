using System;
using Confluent.Kafka;
using System.Threading.Tasks;

namespace InventoryProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092" // Update with your Kafka server details
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            var json = @"{
                ""declarationType"":""Imports"",
                ""payerTin"":10003,
                ""email"":""anchal@gmail.com"",
                ""importCountry"":""Sweden"",
                ""exportCountry"":""India"",
                ""consigneeTIN"":10001,
                ""consignorTIN"":10002,
                ""date"":""2024-02-09T00:00:00"",
                ""transportationMode"":""byAir"",
                ""declarationGoodItems"":[
                    {""goodItemId"":1,""quantity"":2,""materialType"":""Plastic"",""price"":2000.00,""declarationId"":6},
                    {""goodItemId"":2,""quantity"":3,""materialType"":""Electronic"",""price"":5000.00,""declarationId"":6},
				    //{""goodItemId"":3,""quantity"":3,""materialType"":""crude oil"",""price"":5000.00,""declarationId"":6}
                ]
            }";

            var message = new Message<Null, string> { Value = json };

            var deliveryResult = await producer.ProduceAsync("declaration-topic", message);
            Console.WriteLine($"Produced message to: {deliveryResult.TopicPartitionOffset}");

            // Wait for user input before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
