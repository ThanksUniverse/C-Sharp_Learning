using Dapper.Contrib.Extensions;
using DapperProject.Interface;

namespace DapperProject.Models
{
    [Table("[Role]")]
    public class Role : IItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}