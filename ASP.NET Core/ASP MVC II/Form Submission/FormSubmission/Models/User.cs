//ignore the none value attribute 
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models;

public class User
{
    [Required]
    [MinLength(2)]

    // [NoZNames]
    public string Name { get; set; }
    [Required]
    [EmailAddress]

    public string Email { get; set; }
    [Required]
    [PastDate]
    public DateTime DOB { get; set; }
    [Required]
    [MinLength(8)]
    public string Password { get; set; }
    [Required]
    // [OddNumber]
    [PrimeNumber]
    public int Number { get; set; }

}

public class PastDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((DateTime)value).Date >= DateTime.Now.Date)
        {
            return new ValidationResult("date should be in past");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}

public class OddNumberAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((int)value)%2 == 0)
        {
            return new ValidationResult("must be a whole odd number");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}
public class PrimeNumberAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        int n = (int)value;
        int flag = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                flag++;
            }
        }

        if (flag != 2)
        {
            return new ValidationResult("must be a prime number");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}