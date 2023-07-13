using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();
            foreach (var it in categories)
            {
                Console.WriteLine($"{it.Id} - {it.Name} - ({it.Slug})");
            }
        }
    }
}