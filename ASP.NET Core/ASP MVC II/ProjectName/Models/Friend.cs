//ignore the none value attribute 
#pragma warning disable CS8618

namespace ProjectName.Models;

public class Friend
{

    // if i want to be the value as null put ? after type 
    public string FristName { get; set; }
    public string LastName { get; set; }
    // public string FristName { get; set; } = null!;
    // public string LastName { get; set; } = null!;
    //optional
    public string? Location { get; set; }
    public int Age { get; set; }

}