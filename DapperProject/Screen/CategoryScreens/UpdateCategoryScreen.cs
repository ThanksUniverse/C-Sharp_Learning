using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar uma category");
            Console.WriteLine("--------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine($"Category {category.Name} atualizada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel salvar a category");
                Console.WriteLine(ex.Message);
            }
        }
    }
}