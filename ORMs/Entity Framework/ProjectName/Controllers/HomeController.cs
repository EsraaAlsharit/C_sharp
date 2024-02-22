// Using statements
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;

using ProjectName.Models;
namespace ProjectName.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // Add a private variable of type MyContext (or whatever you named your context file)
    private MyContext _context;
    // Here we can "inject" our context service into the constructor 
    // The "logger" was something that was already in our code, we're just adding around it   
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        // When our HomeController is instantiated, it will fill in _context with context
        // Remember that when context is initialized, it brings in everything we need from DbContext
        // which comes from Entity Framework Core
        _context = context;
    }

    [HttpGet("")]

    public IActionResult Index()
    {
        // Now any time we want to access our database we use _context   
        List<Monster> AllMonsters = _context.Monsters.ToList();
        // Monster؟ Monster = _context.Monsters.FirstOrDefault(i => i.MonsterId== id);
        return View(AllMonsters);
    }
    public IActionResult Default()
    {
        return View();
    }
    [SessionCheck]
    public IActionResult New()
    {
        return View();
    }
    [SessionCheck]
    [HttpGet("{id}")]
    public IActionResult Show(int id)
    {
        Monster? monster = _context.Monsters.FirstOrDefault(i => i.MonsterId == id);

        return View(monster);
    }
    [SessionCheck]
    [HttpGet("{id}/edit")]
    public IActionResult Edit(int id)
    {
        // Now any time we want to access our database we use _context   
        Monster? monster = _context.Monsters.FirstOrDefault(i => i.MonsterId == id);
        return View(monster);
    }
    [SessionCheck]
    [HttpPost("{id}/Update")]
    public IActionResult Update(int id, Monster newMon)
    {

        Monster? monster = _context.Monsters.FirstOrDefault(i => i.MonsterId == id);

        if (ModelState.IsValid)
        {
            monster.Name = newMon.Name;
            monster.Height = newMon.Height;
            monster.Description = newMon.Description;
            monster.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            // Handle unsuccessful validations
            return View("Form", newMon);

        }
    }

    [SessionCheck]
    [HttpPost("{id}/destroy")]
    public IActionResult Destroy(int id)
    {
        Monster? MonToDelete = _context.Monsters.SingleOrDefault(i => i.MonsterId == id);
        // Once again, it could be a good idea to verify the monster exists before deleting
        _context.Monsters.Remove(MonToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost("Home/create")]
    public IActionResult Create(Monster newMon)
    {
        if (ModelState.IsValid)
        {
            // We can take the Monster object created from a form submission
            // and pass the object through the .Add() method  
            // Remember that _context is our database  
            _context.Add(newMon);
            // OR _context.Monsters.Add(newMon); if we want to specify the table
            // EF Core will be able to figure out which table you meant based on the model  
            // VERY IMPORTANT: save your changes at the end! 
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            // Handle unsuccessful validations
            return View("New");
        }
    }

    [HttpPost("users/create")]
    public IActionResult Method(User newUser)
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
        }
        else
        {
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
                return View("SomeView");
            }
            // Otherwise, we have a user, now we need to check their password                 
            // Initialize hasher object        
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            // Verify provided password against hash stored in db        
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);                                    // Result can be compared to 0 for failure        
            if (result == 0)
            {
                // Handle failure (this should be similar to how "existing email" is handled)        
                return RedirectToAction("SomeAction");
            }
            // Handle success (this should route to an internal page)  
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("SomeAction");
        }
        else
        {
            // Handle else
            return View("SomeAction");
        }
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



}
