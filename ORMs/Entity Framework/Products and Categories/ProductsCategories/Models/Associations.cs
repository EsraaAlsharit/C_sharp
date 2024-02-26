#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProductsCategories.Models;
public class Associations
{
    //key is the incremented id for the data bace
    [Key]
    public int AssociationsId { get; set; }
    [Required]
    // The IDs linking to the adjoining tables   
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    // Our navigation properties - don't forget the ?    
    public Product? Product { get; set; }
    public Category? Category { get; set; }

    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}
