
using Application.IServices;
using Application.Services;
using Domain;
using Domain.ReqModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace InventoryConsumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumerController : ControllerBase
    {
        private readonly IConsumerService _consumer;
        public ConsumerController(IConsumerService consumer)
        {
            _consumer = consumer;
        }
        [HttpGet]
        public IActionResult StartConsuming()
        {
			var res=_consumer.StartConsuming();
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
