using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.PostScreens
{
    public static class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar post id");
            Console.WriteLine("--------------");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(new Post
            {
                Id = id
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void Delete(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Delete(post);
                Console.WriteLine($"Succesfully deleted {post.Title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos deletar seu post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}