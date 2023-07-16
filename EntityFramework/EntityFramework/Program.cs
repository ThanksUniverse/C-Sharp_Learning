using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public static class Program
    {
        public static void Main()
        {
            using var context = new BlogDataContext();

            var post = context
                .Posts
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderByDescending(x => x.LastUpdateDate)
                .FirstOrDefault(x => x.Id == 1);

            post.Author.Name = "Pedro Bertoluchi";

            context.Posts.Update(post);
            context.SaveChanges();
        }
    }
}