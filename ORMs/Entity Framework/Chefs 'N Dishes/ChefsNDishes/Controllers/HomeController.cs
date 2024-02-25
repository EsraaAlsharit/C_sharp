// Using statements
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Web;




using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Chef> AllChefs = _context.Chefs.Include(c => c.AllDishes).ToList();
        return View(AllChefs);
    }

    public IActionResult Dishes()
    {
        List<Dish> AllDishes = _context.Dishes.Include(c => c.Creator).ToList();
        return View(AllDishes);
    }
    public IActionResult ChefForm()
    {
        return View();
    }
    public IActionResult DishForm()
    {
        List<Chef> AllChefs = _context.Chefs.ToList();
        // List<Chef> AllChefs = _context.Chefs.Select(x => new {x.ChefId}).ToList();
        // IEnumerable<Chef> AllChefs = _context.Chefs.Include(c => c.AllDishes).ToDictionary(us => us.ChefId, us => us.FirstName);
        // ViewBag.AllChefs = new SelectList(AllChefs, "Id", "FirstName");
        // ViewBag.AllChefs = new SelectList(_context.Chefs.ToDictionary(us => us.ChefId, us => us.FirstName), "Key", "Value");
        // ViewBag.AllChefs = new SelectList(_context.Chefs, "Id", "FirstName");
        // Console.WriteLine(AllChefs[0].ChefId);

        ViewBag.AllChefs = AllChefs;
        return View();
    }

    [HttpPost("CreateChef")]
    public IActionResult CreateChef(Chef newChef)
    {
        if (ModelState.IsValid)
        {
            // int Age =new DateTime.now -newChef.DOB;
            int age = 0;
            age = DateTime.Now.Year - newChef.DOB.Year;
            if (DateTime.Now.DayOfYear < newChef.DOB.DayOfYear)
                age = age - 1;

            newChef.Age = age;
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("ChefForm");
        }
    }
    [HttpPost("CreateDish")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Dishes");
        }
        else
        {
            IEnumerable<Chef> AllChefs = _context.Chefs.ToList();
            ViewBag.AllChefs = AllChefs;

            return View("DishForm");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
