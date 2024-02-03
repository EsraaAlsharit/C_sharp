//ignore the none value attribute 
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace ProjectName.Models;

public class User
{
    [Required]
    [NoZNames]
    public string Username { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(6)]
    public string Password { get; set; }

}

public class NoZNamesAttribute : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((string) value).ToLower()[0]=='z')
        {
            return new ValidationResult("userName that start with Z allowed!");
        } else {
            return ValidationResult.Success;
        }
    }
}