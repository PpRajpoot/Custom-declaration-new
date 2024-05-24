using Application.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerTesting.Controllers
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
			_consumer.StartConsuming();

			return Ok();
		}
	}
}
