#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProjectName.Models;
public class Monster
{
    //key is the incremented id for the data bace
    [Key]
    public int MonsterId { get; set; }
    public string Name { get; set; } 
    public int Height { get; set; }
    public string Description { get; set; }
    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}