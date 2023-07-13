using Dapper.Contrib.Extensions;
using DapperProject.Interface;

namespace DapperProject.Models
{
    [Table("[Tag]")]
    public class Tag : IItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public int Count { get; set; }
    }
}