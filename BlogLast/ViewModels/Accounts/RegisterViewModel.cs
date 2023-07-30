using System.ComponentModel.DataAnnotations;

namespace BlogLast.ViewModels.Accounts
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O nome eh obrigatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O Email eh obrigatorio")]
        [EmailAddress(ErrorMessage = "O email eh invalido")]
        public string Email { get; set; }
    }
}
