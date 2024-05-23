using System.ComponentModel.DataAnnotations;

namespace BankApp.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Assunto é obrigatório.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "O campo Mensagem é obrigatório.")]
        public string Message { get; set; }
    }
}
