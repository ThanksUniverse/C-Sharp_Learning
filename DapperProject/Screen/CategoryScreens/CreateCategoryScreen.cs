using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("--------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine($"Category {category.Name} cadastrada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel salvar a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}