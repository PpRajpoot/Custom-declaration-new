
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationProducer.IServices
{
    public interface IProducerService
    {
        Task<string> StartProducing();


    }
}
