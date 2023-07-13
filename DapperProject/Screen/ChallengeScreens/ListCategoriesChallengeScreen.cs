using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.ChallengeScreens
{
    public static class ListCategoriesChallengeScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias e suas quantidades de posts");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuChallengeScreen.Load();
        }

        public static void List()
        {
            var category = new CategoryRepository(Database.Connection);
            var categories = category.GetCategoriesCount();
            foreach (var it in categories)
            {
                Console.WriteLine($"{it.Id} - {it.Name} - {it.Count}");
            }
        }
    }
}