using System.Text.RegularExpressions;
using BlogLast.Data;
using BlogLast.Extensions;
using BlogLast.Models;
using BlogLast.Services;
using BlogLast.ViewModels;
using BlogLast.ViewModels.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecureIdentity.Password;

namespace BlogLast.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("v1/accounts")]
        public async Task<IActionResult> Post(
                [FromBody] RegisterViewModel model,
                [FromServices] EmailService emailService,
                [FromServices] BlogDataContext context
            )
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Slug = model.Email.Replace("@", "-").Replace(".", "-"),
            };

            var password = PasswordGenerator.Generate(25, includeSpecialChars: true);
            user.PasswordHash = PasswordHasher.Hash(password);

            try
            {
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();

                emailService.Send(
                    user.Name,
                    user.Email,
                    "Bem vindo ao Blog",
                    $"Sua senha eh <strong>{password}</strong>");

                return Ok(new ResultViewModel<string>("Success", null));
            }
            catch (DbUpdateException)
            {
                return StatusCode(400, new ResultViewModel<string>("0x06 - Este E-Mail ja esta em uso."));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<string>("Falha interna na conexao"));
            }
        }

        [HttpPost("v1/accounts/login")]
        public async Task<IActionResult> Login(
            [FromBody] LoginViewModel model,
            [FromServices] BlogDataContext context,
            [FromServices] TokenService tokenService
            )
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

            var user = await context
                .Users
                .AsNoTracking()
                .Include(x => x.Roles)
                .FirstOrDefaultAsync(x => x.Email == model.Email);

            if (user == null)
                return StatusCode(401, new ResultViewModel<string>("Usuario ou senha invalidos"));

            var verifyHash = PasswordHasher.Verify(user.PasswordHash, model.Password);
            if (!verifyHash)
                return StatusCode(401, new ResultViewModel<string>("Usuario ou senha invalidos"));

            try
            {
                var token = tokenService.GenerateToken(user);
                return Ok(new ResultViewModel<string>(token, null));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<string>("Falha interna no servidor"));
            }
        }

        [Authorize]
        [HttpPost("v1/accounts/upload-image")]
        public async Task<IActionResult> UploadImage(
            [FromBody] UploadImageViewModel model,
            [FromServices] BlogDataContext context
        )
        {
            var fileName = $"{Guid.NewGuid().ToString()}.jpg";
            var data = new Regex(@"^data:image\/[a-z]+;base64,")
                .Replace(model.Base64Image, "");
            var bytes = Convert.FromBase64String(data);

            try
            {
                await System.IO.File.WriteAllBytesAsync($"wwwroot/images/{fileName}", bytes);
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<string>("Falha interna no servidor"));
            }

            var user = await context
                .Users
                .FirstOrDefaultAsync(x => x.Email == User.Identity.Name);

            if (user == null)
                return NotFound(new ResultViewModel<Category>("Usuario nao encontrado"));

            user.Image = $"https://localhost:0000/images/{fileName}";
            try
            {
                context.Users.Update(user);
                await context.SaveChangesAsync();
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<string>("Falha interna no servidor"));
            }

            return Ok(new ResultViewModel<string>("Imagem alterada com sucesso"));
        }
    }
}
