#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsCategories.Models;
public class Category
{
    //key is the incremented id for the data bace
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public List<Associations> Associations { get; set; } = new List<Associations>();
    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
