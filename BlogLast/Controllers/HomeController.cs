using Microsoft.AspNetCore.Mvc;

// Health Check
namespace BlogLast.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
