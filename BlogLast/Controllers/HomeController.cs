using BlogLast.Attributes;
using Microsoft.AspNetCore.Mvc;

// Health Check
namespace BlogLast.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        [ApiKey]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
