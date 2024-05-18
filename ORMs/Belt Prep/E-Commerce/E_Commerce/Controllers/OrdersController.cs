using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using E_Commerce.Models;

namespace E_Commerce.Controllers;

public class OrderController : Controller
{
    private MyContext _context;

    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        DashboardOrder dashboard = new DashboardOrder
        {
            // AllOrders = _context.Orders.ToList()
            AllOrders = _context.Orders.Include(g => g.Product).Include(g => g.Customer).ToList()

        };
        ViewBag.AllCustomers = _context.Customers.ToList();
        ViewBag.AllProducts = _context.Products.ToList();

        return View(dashboard);
    }

    public IActionResult Create(Order NewOrder)
    {

        if (ModelState.IsValid)
        {
            _context.Add(NewOrder);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        else
        {
            DashboardOrder dashboard = new DashboardOrder
            {
                // AllOrders = _context.Orders.ToList()
                AllOrders = _context.Orders.Include(g => g.Product).Include(g => g.Customer).ToList()

            };
            ViewBag.AllCustomers = _context.Customers.ToList();
            ViewBag.AllProducts = _context.Products.ToList();

            return View("Index",dashboard);
        }
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
