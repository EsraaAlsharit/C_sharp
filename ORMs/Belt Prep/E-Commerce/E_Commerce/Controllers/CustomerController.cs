using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;
using E_Commerce.Models;

namespace E_Commerce.Controllers;

public class CustomerController : Controller
{
    private MyContext _context;

    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }


    public IActionResult Index()
    {
        DashboardCustomer dashboard = new DashboardCustomer
        {
            AllCustomers = _context.Customers.ToList()
        };
        return View(dashboard);
    }

    public IActionResult Create(Customer NewCustomer)
    {

        if (ModelState.IsValid)
        {
            _context.Add(NewCustomer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        else
        {
            DashboardCustomer dashboard = new DashboardCustomer
            {
                AllCustomers = _context.Customers.ToList()
            };
            return View("Index", dashboard);
        }
    }


    [HttpPost("{id}/destroy")]
    public IActionResult Destroy(int id)
    {
        Customer? CustomerToDelete = _context.Customers.SingleOrDefault(i => i.CustomerId == id);
        _context.Customers.Remove(CustomerToDelete);

        _context.SaveChanges();
        return RedirectToAction("Index");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
