#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;
public class Chef
{
    //key is the incremented id for the data bace
    [Key]
    public int ChefId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [PastDate]

    public DateTime DOB { get; set; }
    public int Age { get; set; }

    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // Our navigation property to track the many Posts our user has made
    // Be sure to include the part about instantiating a new List!
    public List<Dish> AllDishes { get; set; } = new List<Dish>();
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