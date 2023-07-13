using DapperProject.Models;
using DapperProject.Repositories;

namespace DapperProject.Screen.PostScreens
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar post");
            Console.WriteLine("--------------");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

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

            Update(new Post
            {
                Id = id,
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

        private static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine($"Succesfully updated {post.Title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao conseguimos atualizar seu post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}