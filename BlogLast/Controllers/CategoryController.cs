using BlogLast.Data;
using BlogLast.Extensions;
using BlogLast.Models;
using BlogLast.ViewModels;
using BlogLast.ViewModels.Categories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace BlogLast.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categories")] // Versionamento de codigo.
        public async Task<IActionResult> GetAsync(
            [FromServices] IMemoryCache cache,
            [FromServices] BlogDataContext context
            )
        {
            try
            {
                var categories = cache.GetOrCreate("CategoriesCache", entry =>
                {
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1);
                    return GetCategories(context);
                });
                return Ok(new ResultViewModel<List<Category>>(categories));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<List<Category>>("0x01 - Nao foi possivel encontrar as categorias"));
            }
        }

        private List<Category> GetCategories(BlogDataContext context)
        {
            return context.Categories.ToList();
        }

        [HttpGet("v1/categories/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromRoute] int id,
            [FromServices] BlogDataContext context
        )
        {
            try
            {
                var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
                if (category == null)
                    return NotFound(new ResultViewModel<Category>("Conteudo nao encontrado."));

                return Ok(new ResultViewModel<Category>(category));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Category>("0x02 - Nao foi possivel pegar a categoria"));
            }
        }

        [HttpPost("v1/categories")]
        public async Task<IActionResult> PostAsync(
            [FromBody] EditorCategoryViewModel category,
            [FromServices] BlogDataContext context
        )
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<Category>(ModelState.GetErrors()));

            try
            {
                var nCategory = new Category
                {
                    Name = category.Name,
                    Slug = category.Slug.ToLower(),
                };
                await context.Categories.AddAsync(nCategory);
                await context.SaveChangesAsync();

                return Created($"v1/categories/{nCategory.Id}", new ResultViewModel<Category>(nCategory));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Category>("0x03 - Nao foi possivel inserir a categoria"));
            }
        }

        [HttpPut("v1/categories/{id:int}")]
        public async Task<IActionResult> PutAsync(
            [FromRoute] int id,
            [FromBody] EditorCategoryViewModel category,
            [FromServices] BlogDataContext context
        )
        {
            try
            {
                var ncategory = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);

                if (ncategory == null) return NotFound(new ResultViewModel<Category>("Conteudo nao encontrado"));

                ncategory.Name = category.Name;
                ncategory.Slug = category.Slug;

                context.Categories.Update(ncategory);
                await context.SaveChangesAsync();

                return Ok(new ResultViewModel<Category>(ncategory));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Category>("0x04 - Nao foi possivel atualizar a categoria"));
            }
        }

        [HttpDelete("v1/categories/{id:int}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] int id,
            [FromBody] Category category,
            [FromServices] BlogDataContext context
        )
        {
            try
            {
                var lcategory = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
                if (lcategory == null) return NotFound();

                context.Categories.Remove(lcategory);
                await context.SaveChangesAsync();

                return Ok(new ResultViewModel<Category>(category));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Category>("0x05 - Nao foi possivel deletar a categoria"));
            }
        }
    }
}
