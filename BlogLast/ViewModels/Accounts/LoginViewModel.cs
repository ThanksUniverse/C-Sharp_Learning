using System.ComponentModel.DataAnnotations;

namespace BlogLast.ViewModels.Accounts
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Password { get; set; }
    }
}
