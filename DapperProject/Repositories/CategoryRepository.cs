using Dapper;
using DapperProject.Models;
using Microsoft.Data.SqlClient;

namespace DapperProject.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        private readonly SqlConnection _connection;

        public CategoryRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public List<Category> GetCategoriesCount()
        {
            var query = @"
            select
                Category.Id,
                Category.Name,
                Count(*) as Count
            from
                Category
            inner join
                [Post] on [Post].[CategoryId] = [Category].[Id]
            group by
                [Category].[Name],
                [Category].[Id]
            ";

            var items = _connection.Query<Category>(query);
            return items.ToList();
        }
    }
}