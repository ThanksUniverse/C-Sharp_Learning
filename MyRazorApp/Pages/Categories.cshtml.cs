using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new();

    public void OnGet(int skip = 0, int take = 100)
    {
        var temp = new List<Category>();
        for (int i = 0; i <= 2000; i++)
        {
            temp.Add(
                new Category(
                    i,
                    $"Category {i}",
                    i * 18.95M));
        }

        CategoryList = temp.Skip(skip)
            .Take(take + 1)
            .ToList();
    }
}

public record Category(
    int Id,
    string Title,
    decimal Price
);