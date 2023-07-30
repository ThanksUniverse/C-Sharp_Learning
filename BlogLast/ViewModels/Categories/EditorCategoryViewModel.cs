using System.ComponentModel.DataAnnotations;

namespace BlogLast.ViewModels.Categories
{
    public class EditorCategoryViewModel // Criado para nao ter que preencher todos os dados do category e so o necessario
    {
        [Required(ErrorMessage = "O nome eh obrigatorio")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O slug eh obrigatorio")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        public string Slug { get; set; }
    }
}
