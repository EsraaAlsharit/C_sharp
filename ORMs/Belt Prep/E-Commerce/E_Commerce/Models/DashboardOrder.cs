#pragma warning disable CS8618
// using statements and namespace go here
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public class DashboardOrder
{
    public List<Order> AllOrders { get; set; }    
    public Order Order { get; set; }    
   
}