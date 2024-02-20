// Using statements
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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
    public IActionResult New()
    {
        return View();
    }

    [HttpGet("{id}")]
    public IActionResult Show(int id)
    {
        Monster? monster = _context.Monsters.FirstOrDefault(i => i.MonsterId == id);

        return View(monster);
    }

    [HttpGet("{id}/edit")]
    public IActionResult Edit(int id)
    {
        // Now any time we want to access our database we use _context   
        Monster? monster = _context.Monsters.FirstOrDefault(i => i.MonsterId == id);
        return View(monster);
    }

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
            return View("Form",newMon);

        }
    }


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
public IActionResult Create(Monster newMon){
    if (ModelState.IsValid){
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
}