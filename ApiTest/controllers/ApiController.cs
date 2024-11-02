using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class HelloController : ControllerBase {
		[HttpGet]
		public string Get() {
			return "Hello, World!";
		}
	}
}