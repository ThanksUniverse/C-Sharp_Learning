using Dapper.Contrib.Extensions;
using DapperProject.Interface;

namespace DapperProject.Models
{
    [Table("[UserRole]")]
    public class UserRole : IItems
    {
        [Write(false)]
        public string Name { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}