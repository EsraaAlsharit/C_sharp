#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;
public class Dish
{
    //key is the incremented id for the data bace
    [Key]
    public int DishId { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(1, 5)]
    public int Tastiness { get; set; }
    [GreaterThanZero]
    [Required]
    public int Calories { get; set; }
    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int ChefId { get; set; }
    // Our navigation property to track which User made this Post
    // It is VERY important to include the ? on the datatype or this won't work!
    public Chef? Creator { get; set; }
}

public class GreaterThanZeroAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((int)value) <= 0)
        {
            return new ValidationResult("must be greater than 0");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}