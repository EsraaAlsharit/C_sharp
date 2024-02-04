//ignore the none value attribute 
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DateValidator.Models;

public class Events
{
    [Required]
    public string Title { get; set; }

    [FutureDate]
    [Required]
    public DateTime Date { get; set; }

}

public class FutureDateAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((DateTime)value) > DateTime.Now)
        {
            // return new ValidationResult("userName that start with Z allowed!");
            return new ValidationResult("date should be in past");
        } else {
            return ValidationResult.Success;
        }
    }
}
