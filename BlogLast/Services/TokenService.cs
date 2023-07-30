using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BlogLast.Extensions;
using BlogLast.Models;
using Microsoft.IdentityModel.Tokens;

namespace BlogLast.Services
{
    public class TokenService
    {
        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler(); // Instancia o manipulador de token
            var key = Encoding.ASCII.GetBytes(Configuration.JwtKey); // Transforma a nossa key em bytes
            var claims = user.GetClaims();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            }; // Vai segurar nossa stri
            var token = tokenHandler.CreateToken(tokenDescriptor); // Cria o token
            return tokenHandler.WriteToken(token); // Converte para string
        }
    }
}
