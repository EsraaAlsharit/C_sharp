#pragma warning disable CS8618
// We can disable our warnings safely because we know the framework will assign non-null values 
// when it constructs this class for us.
using Microsoft.EntityFrameworkCore;
namespace WeddingPlanner.Models;
// the MyContext class represents a session with our MySQL database, allowing us to query for or save data
// DbContext is a class that comes from EntityFramework, we want to inherit its features
public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options) { } 
    public DbSet<User> Users { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    public DbSet<Guest> Guests { get; set; }
}