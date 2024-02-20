#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProjectName.Models;
public class Product
{
    //key is the incremented id for the data bace
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; } 
    public int Price { get; set; }
    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}