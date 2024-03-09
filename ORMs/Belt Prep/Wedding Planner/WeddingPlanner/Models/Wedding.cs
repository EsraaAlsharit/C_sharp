#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;
public class Wedding
{
    [Key]
    public int WeddingId { get; set; }
    [Required]
    public string WedderOne { get; set; }
    [Required]
    public string WedderTwo { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    [FutureDate]
    public DateTime Date { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<Guest> Guests { get; set; } = new List<Guest>();
    public int UserId { get; set; }
    // Our navigation property to track which User made this Post
    // It is VERY important to include the ? on the datatype or this won't work!
    public User? Creator { get; set; }

}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((DateTime)value) <= DateTime.Now.Date)
        {
            // return new ValidationResult("userName that start with Z allowed!");
            return new ValidationResult("date should be in future");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}