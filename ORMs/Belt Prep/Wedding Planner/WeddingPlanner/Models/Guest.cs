#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;

public class Guest
{
    //key is the incremented id for the data bace
    [Key]
    public int GuestId { get; set; }
    [Required]
    // The IDs linking to the adjoining tables   
    public int WeddingId { get; set; }
    public int UserId { get; set; }
    // Our navigation properties - don't forget the ?    
    public Wedding? Wedding { get; set; }
    public User? User { get; set; }

    //time stamp
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}
