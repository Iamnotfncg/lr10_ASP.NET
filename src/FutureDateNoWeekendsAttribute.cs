using System.ComponentModel.DataAnnotations;

namespace lr10
{
    public class FutureDateNoWeekendsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date.Date < DateTime.Now.Date)
                    return new ValidationResult("Будь ласка, виберіть дату у майбутньому.");

                if (date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                    return new ValidationResult("Будь ласка, виберіть дату, яка не попадає на вихідні.");

                return ValidationResult.Success;
            }

            return new ValidationResult("Некоректний формат дати.");
        }
    }
}
