using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de posts");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Post>(Database.Connection);
            var posts = repository.Get();
            foreach (var it in posts)
            {
                Console.WriteLine($"{it.Id} -> {it.Title}\n -> ({it.Body})");
                Console.WriteLine("---------------");
            }
        }
    }
}