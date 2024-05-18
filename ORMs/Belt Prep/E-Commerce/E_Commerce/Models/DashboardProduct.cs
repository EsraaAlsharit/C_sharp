#pragma warning disable CS8618
// using statements and namespace go here
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public class DashboardProduct
{
    public List<Product> AllProducts { get; set; }    
    public Product Product { get; set; }    
   
}