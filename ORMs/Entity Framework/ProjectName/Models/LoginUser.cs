#pragma warning disable CS8618
// using statements and namespace go here
public class LoginUser
{
    // No other fields!
    [Required]    
    public string Email { get; set; }    
    [Required]    
    public string Password { get; set; } 
}