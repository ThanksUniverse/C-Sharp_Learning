using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Eager Loading
            using var context = new BlogDataContext();

            var posts = context.PostWithTagsCounts.ToList();

            foreach (var postWithTagsCount in posts)
            {
                Console.WriteLine(postWithTagsCount.Count);
            }

        }

        public static List<Post> GetPosts(BlogDataContext context, int skip = 0, int take = 1000)
        {
            var posts = context
                .Posts
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToList();
            return posts;
        }
    }
}