using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.ChallengeScreens
{
    public static class ListPostsCategoryChallengeScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de posts de uma categoria");
            Console.WriteLine("--------------");
            ListCategoriesChallengeScreen.List();
            Console.WriteLine("Qual id de categoria voce quer ver ?");
            int id = int.Parse(Console.ReadLine());
            List(id);
            Console.ReadKey();
            MenuChallengeScreen.Load();
        }

        private static void List(int id)
        {
            var tags = new TagRepository(Database.Connection);
            var items = tags.GetTagCount(id);
            foreach (var it in items)
            {
                Console.WriteLine($"{it.Id} - {it.Name}");
            }
        }
    }
}