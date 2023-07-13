using Dapper.Contrib.Extensions;
using DapperProject.Interface;

namespace DapperProject.Models
{
    [Table("[Category]")]
    public class Category : IItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        [Write(false)]
        public List<Post> Posts { get; set; }
        [Write(false)]
        public int Count { get; set; }
    }
}