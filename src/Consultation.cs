using System.ComponentModel.DataAnnotations;

namespace lr10
{
    public class Consultation
    {
        [Required(ErrorMessage = "Будь ласка, введіть ім'я та прізвище.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть коректний email.")]
        [EmailAddress(ErrorMessage = "Введіть коректний email.")]
        public string? Email { get; set; }

        
        [Required(ErrorMessage = "Будь ласка, оберіть дату консультації.")]
        [DataType(DataType.Date)]
        [FutureDateNoWeekends]
        public DateTime ConsultationDate { get; set; }

        [Required(ErrorMessage = "Будь ласка, оберіть продукт.")]
        public string? Product { get; set; }
    }
}
