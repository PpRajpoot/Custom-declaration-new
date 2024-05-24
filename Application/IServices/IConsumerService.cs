using Confluent.Kafka;
using Domain;
using Domain.ReqModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IConsumerService
    {
        string StartConsuming();
        void EndConsuming(IConsumer<Ignore, string> consumer);
        //  void TestingConsuming();
        //Task ConsumeAsync();

	}
}
