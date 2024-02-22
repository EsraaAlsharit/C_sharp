using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;

using LoginRegistration.Models;

namespace LoginRegistration.Controllers;

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
        return View();
    }

    [SessionCheck]
    public IActionResult Success()
    {
        return View();
    }

    [HttpPost("/create")]
    public IActionResult Create(User newUser)
    {
        if (ModelState.IsValid)
        {
            // Initializing a PasswordHasher object, providing our User class as its type            
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            // Updating our newUser's password to a hashed version         
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            //Save your user object to the database 
            _context.Add(newUser);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("Index");
            // handle else
        }
    }



    public IActionResult Login(LoginUser userSubmission)
    {
        if (ModelState.IsValid)
        {
            // If initial ModelState is valid, query for a user with the provided email        
            User? userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
            // If no user exists with the provided email        
            if (userInDb == null)
            {
                // Add an error to ModelState and return to View!            
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("Index");
            }
            // Otherwise, we have a user, now we need to check their password                 
            // Initialize hasher object        
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            // Verify provided password against hash stored in db        
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);                                    // Result can be compared to 0 for failure        
            if (result == 0)
            {
                // Handle failure (this should be similar to how "existing email" is handled)        
                return RedirectToAction("Index");
            }
            // Handle success (this should route to an internal page)  
            HttpContext.Session.SetInt32("UserId", userInDb.UserId);
            return RedirectToAction("Success");
        }
        else
        {
            // Handle else
            return View("Index");
        }
    }

    [HttpGet("Logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
    
    // Name this anything you want with the word "Attribute" at the end
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Find the session, but remember it may be null so we need int?
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            // Check to see if we got back null
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
