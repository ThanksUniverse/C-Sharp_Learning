using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();
            foreach (var it in tags)
            {
                Console.WriteLine($"{it.Id} - {it.Name} - ({it.Slug})");
            }
        }
    }
}