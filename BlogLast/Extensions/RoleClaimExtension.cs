using System.Security.Claims;
using BlogLast.Models;

namespace BlogLast.Extensions
{
    public static class RoleClaimExtension
    {
        public static IEnumerable<Claim> GetClaims(this User user)
        {
            var result = new List<Claim>
            {
                new(ClaimTypes.Name, user.Email)
            };

            result.AddRange(
                user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Slug))
                );
            return result;
        }
    }
}
