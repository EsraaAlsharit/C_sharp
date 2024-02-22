#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProjectName.Models;
public class Costumer
{
    //key is the incremented id for the data bace
    [Key]
    public int CostumerId { get; set; }
    public string Username { get; set; } 
    public int Age { get; set; }
    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}