using Dapper.Contrib.Extensions;
using DapperProject.Interface;

namespace DapperProject.Models
{
    [Table("[PostTag]")]
    public class PostTag : IItems
    {
        public int PostId { get; set; }
        public int TagId { get; set; }

        [Write(false)]
        public string Name { get; set; }
    }
}