using Blog.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlogLast.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categories")] // Versionamento de codigo.
        public IActionResult Get(
            [FromServices] BlogDataContext context
            )
        {
            var categories = context.Categories.ToList();
            return Ok(categories);
        }
    }
}
