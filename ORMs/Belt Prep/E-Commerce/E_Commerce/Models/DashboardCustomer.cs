#pragma warning disable CS8618
// using statements and namespace go here
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public class DashboardCustomer
{
    public List<Customer> AllCustomers { get; set; }    
    public Customer Customer { get; set; }    
   
}