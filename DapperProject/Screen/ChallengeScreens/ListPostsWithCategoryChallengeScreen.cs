using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.ChallengeScreens
{
    public static class ListPostsWithCategoryChallengeScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de posts e sua categoria");
            Console.WriteLine("--------------");
            ListAll();
            Console.ReadKey();
            MenuChallengeScreen.Load();
        }

        private static void ListAll()
        {
            var post = new PostRepository(Database.Connection);
            var items = post.GetWithCategory();
            foreach (var it in items)
            {
                Console.WriteLine($"[Post] ID:({it.PID}): {it.Title} - [Tag] ID:({it.Id}) : {it.Name}");
            }
        }
    }
}