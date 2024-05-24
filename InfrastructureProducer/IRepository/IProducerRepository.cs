using DomainProducer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    public interface IProducerRepository
    {
        List<ClsEvent> GetEvent(string id);
    }
}
