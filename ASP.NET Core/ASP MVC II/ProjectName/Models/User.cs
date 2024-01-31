//ignore the none value attribute 
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace ProjectName.Models;

public class User
{
    [Required]
    public string Username { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(6)]
    public string Password { get; set; }

}