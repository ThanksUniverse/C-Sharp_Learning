using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo post");
            Console.WriteLine("--------------");

            Console.Write("CategoryId: ");
            var categoryId = int.Parse(Console.ReadLine());

            Console.Write("AuthorId: ");
            var authorId = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Body: ");
            var body = Console.ReadLine();

            Console.Write("Summary: ");
            var summary = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Post
            {
                CategoryId = categoryId,
                AuthorId = authorId,
                Title = title,
                Body = body,
                Summary = summary,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine($"Succesfully created {post.Title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos inserir seu novo post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}