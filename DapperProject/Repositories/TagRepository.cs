using Dapper;
using DapperProject.Models;
using Microsoft.Data.SqlClient;

namespace DapperProject.Repositories
{
    public class TagRepository : Repository<Tag>
    {
        private readonly SqlConnection _connection;

        public TagRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public List<Tag> GetTagsCount()
        {
            var query = @"
            select
                [Tag].[Id],
                [Tag].[Name],
                Count([Post].CategoryId) as Count
            from
                Tag
            inner join
                PostTag on [PostTag].[TagId] = Tag.Id
            inner join
                Post on [Post].[Id] = [PostTag].[PostId]
            group by
                [Tag].[Name],
                [Tag].[Id]
            ";

            var items = _connection.Query<Tag>(query);
            return items.ToList();
        }

        public List<Tag> GetTagCount(int id)
        {
            var query = @"
            select
                [Tag].[Id],
                [Tag].[Name]
            from
                Tag
            inner join
                PostTag on [PostTag].[TagId] = Tag.Id
            inner join
                Post on [Post].[Id] = [PostTag].[PostId]
            group by
                [Tag].[Name],
                [Tag].[Id]
            having
                [Tag].[Id] = 1
            ";

            var items = _connection.Query<Tag>(query);
            return items.ToList();
        }
    }
}