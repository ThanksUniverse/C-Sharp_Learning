using System.Data;
using System.Data.Common;
using Dapper;
using DapperProject.Models;
using Microsoft.Data.SqlClient;

namespace DapperProject.Repositories
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public List<Post> GetWithCategory()
        {
            var query = @"
            select
                [Post].[Id] as PID,
                [Post].[Title],
                [Post].[AuthorId],
                [Category].[Id],
                [Category].[Name]
            from
                Post
            inner join
                Category on Category.Id = Post.CategoryId
            ";

            var items = _connection.Query<Post>(query);

            return items.ToList();
        }

        public List<Post> GetAllTags()
        {
            var query = @"
            select
                *
            from
                [Post]
            inner join
                [PostTag] on [PostTag].[PostId] = [Post].[Id]
            inner join
                [Tag] on [Tag].[Id] = [PostTag].[TagId]
            ";

            var posts = new List<Post>();

            var items = _connection.Query<Post, Tag, Post>(
                query,
            (post, tag) =>
            {
                var pst = posts.FirstOrDefault(x => x.Id == post.Id);
                if (pst == null)
                {
                    pst = post;
                    if (tag != null)
                        pst.Tags.Add(tag);
                    posts.Add(post);
                }
                else
                {
                    pst.Tags.Add(tag);
                }
                return post;
            }, splitOn: "Id"
            );

            return posts;
        }
    }
}