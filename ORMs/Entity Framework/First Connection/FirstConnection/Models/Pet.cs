#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstConnection.Models;
public class Pet
{
    //key is the incremented id for the data bace
    [Key]
    public int  PetId { get; set; }
    public string Name { get; set; } 
    public int age { get; set; }
    public string type { get; set; }
    public bool fur { get; set; }
    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}