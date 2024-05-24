using DomainProducer;
using Infrastructure.DBContext;
using Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureProducer.Repository
{
    public class ProducerRepossitory : IProducerRepository
    {
        private readonly ProducerContext _producerContext;
        public ProducerRepossitory(ProducerContext producerContext) {
            _producerContext = producerContext;
        }

        public List<ClsEvent> GetEvent(string id)
        {
            return _producerContext.T_Event.ToList();
        }
    }
}
