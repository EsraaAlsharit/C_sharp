#pragma warning disable CS8618
// using statements and namespace go here
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Models;

public class LoginUser
{
    
    [Required]    
    public string Email { get; set; }    
    [Required]    
    public string Password { get; set; } 
}