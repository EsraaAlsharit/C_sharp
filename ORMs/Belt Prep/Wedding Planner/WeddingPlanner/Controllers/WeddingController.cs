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


using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{
    private MyContext _context;

    private readonly ILogger<WeddingController> _logger;

    public WeddingController(ILogger<WeddingController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [SessionCheck]
    public IActionResult Index()
    {
        // List<Wedding> AllWenddings = _context.Weddings.ToList();
        // List<Wedding> AllWenddings = _context.Weddings.Include(g => g.Guests).ToList();

        List<Wedding> AllWenddings = _context.Weddings.Include(g => g.Guests).ThenInclude(g => g.User).ToList();

        return View(AllWenddings);

    }

    [SessionCheck]
    public IActionResult New()
    {
        return View();
    }
    [SessionCheck]

    public IActionResult Create(Wedding NewWedding)
    {
        // Console.WriteLine("HI");
        // Console.WriteLine(NewWedding.UserId);
        if (ModelState.IsValid)
        {
            // NewWedding.UserId = (int)HttpContext.Session.GetInt32("UserId");
            _context.Add(NewWedding);
            _context.SaveChanges();

            return RedirectToAction("Show", new { id = NewWedding.WeddingId });
        }
        else
        {
            return View("New");
        }
    }

    [SessionCheck]
    // [HttpGet("{id}")]
    public IActionResult Show(int id)
    {
        Wedding? wedding = _context.Weddings.Include(Ass => Ass.Guests)
        .ThenInclude(Ass => Ass.User)
        .FirstOrDefault(i => i.WeddingId == id);
        return View(wedding);
        // return View();
    }

    [HttpPost("{id}/destroy")]
    public IActionResult Destroy(int id)
    {
        Wedding? WeddingToDelete = _context.Weddings.SingleOrDefault(i => i.WeddingId == id);
        _context.Weddings.Remove(WeddingToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");

    }

    [HttpPost("addGuest")]
    public IActionResult addGuest(int id, Guest newGuest)
    {

        Guest? guest = null;
        guest = _context.Guests.SingleOrDefault(i => i.UserId == newGuest.UserId && i.WeddingId == newGuest.WeddingId);


        if (guest == null)
        {
            _context.Add(newGuest);
            _context.SaveChanges();
        }
        else
        {
        _context.Guests.Remove(guest);
        _context.SaveChanges();
        }

        return RedirectToAction("Index");
        // return RedirectToAction("Product", new { id = newAssociation.ProductId });
    }

    // Name this anything you want with the word "Attribute" at the end
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Find the session, but remember it may be null so we need int?
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            // Check to see if we got back null
            Console.WriteLine(userId == null);

            if (userId == null)
            {
                // Redirect to the Index page if there was nothing in session
                // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
