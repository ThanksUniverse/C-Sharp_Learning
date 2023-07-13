using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.PostScreens
{
    public static class TagPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar a uma tag");
            Console.WriteLine("--------------");

            Console.Write("Post Id: ");
            var postId = int.Parse(Console.ReadLine());

            Console.Write("Tag Id: ");
            var tagId = int.Parse(Console.ReadLine());

            Create(new PostTag
            {
                PostId = postId,
                TagId = tagId,
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void Create(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Create(postTag);
                Console.WriteLine($"Succesfully added your post to a tag {postTag.PostId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos adicionar seu post a uma tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}