using Microsoft.AspNetCore.Mvc;

namespace Controller_based_Web_API.Controllers
{
    [ApiController]
    [Route("hello")]
    public class HelloController : ControllerBase
    {
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            return Ok($"Hello, {name}");
        }
    }

}
