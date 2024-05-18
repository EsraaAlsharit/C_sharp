using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;
using E_Commerce.Models;

namespace E_Commerce.Controllers;

public class ProductController : Controller
{
    private MyContext _context;

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        DashboardProduct dashboard = new DashboardProduct
        {
            AllProducts = _context.Products.ToList()
        };
        return View(dashboard);
    }

    public IActionResult Create(Product NewProduct)
    {

        if (ModelState.IsValid)
        {
            _context.Add(NewProduct);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        else
        {
            DashboardProduct dashboard = new DashboardProduct
            {
                AllProducts = _context.Products.ToList()
            };
            return View("Index", dashboard);
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
