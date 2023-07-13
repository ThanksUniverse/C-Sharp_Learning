using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.PostScreens
{
    public static class ListPostTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de posts e suas tags");
            Console.WriteLine("--------------");
            ListAll();
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void ListAll()
        {
            var repository = new PostRepository(Database.Connection);
            var posts = repository.GetAllTags();

            foreach (var item in posts)
            {
                Console.WriteLine(item.Title);
                foreach (var tag in item.Tags)
                {
                    Console.WriteLine($"--> {tag.Name}");
                }
            }
        }
    }
}