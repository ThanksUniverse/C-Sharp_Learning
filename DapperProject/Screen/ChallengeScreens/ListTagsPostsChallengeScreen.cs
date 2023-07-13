using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.ChallengeScreens
{
    public static class ListTagsPostsChallengeScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags e suas quantidades de posts");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuChallengeScreen.Load();
        }

        private static void List()
        {
            var tags = new TagRepository(Database.Connection);
            var items = tags.GetTagsCount();
            foreach (var it in items)
            {
                Console.WriteLine($"{it.Id} - {it.Name} - {it.Count}");
            }
        }
    }
}