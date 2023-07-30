using System.ComponentModel.DataAnnotations;

namespace BlogLast.ViewModels.Accounts
{
    public class UploadImageViewModel
    {
        [Required(ErrorMessage = "Imagem invalida")]
        public string Base64Image { get; set; }
    }
}
