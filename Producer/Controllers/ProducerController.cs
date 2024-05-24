using ApplicationProducer.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProducerController : ControllerBase
    {
        private readonly IProducerService _producer;
        public ProducerController(IProducerService producer)
        {
            _producer = producer;
        }
        [HttpGet]
        public IActionResult StartConsuming()
        {
           var res= _producer.StartProducing();
            if (res != null)
            {
                return Ok();
            }
            else
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
            
        }
    }
}
