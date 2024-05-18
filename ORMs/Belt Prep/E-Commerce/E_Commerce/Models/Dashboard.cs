#pragma warning disable CS8618
// using statements and namespace go here
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public class Dashboard
{
    public List<Product> AllProducts { get; set; }    
    public List<Order> AllOrders { get; set; } 
    public List<Customer> AllCustomers { get; set; } 
}