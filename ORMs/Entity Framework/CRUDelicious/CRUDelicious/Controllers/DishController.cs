using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class DishController : Controller
{
    private readonly ILogger<DishController> _logger;
    private MyContext _context;


    public DishController(ILogger<DishController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;

    }

    public IActionResult Index()
    {
        List<Dish> AllDishes = _context.Dishes.ToList();
        return View(AllDishes);
    }

    public IActionResult New()
    {
        return View();
    }
    [HttpGet("{id}")]
    public IActionResult Show(int id)
    {
        Dish? dish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
        return View(dish);
    }
    [HttpGet("{id}/edit")]
    public IActionResult Edit(int id)
    {
        Dish? dish = _context.Dishes.FirstOrDefault(i => i.DishId == id);
        Console.WriteLine(dish.Name);

        return View(dish);
    }

    [HttpPost("{id}/update")]
    public IActionResult Update(int id, Dish newDish)
    {

        Console.WriteLine("update");

        Dish? dish = _context.Dishes.FirstOrDefault(i => i.DishId == id);

        if (ModelState.IsValid)
        {
            dish.Name = newDish.Name;
            dish.Chef = newDish.Chef;
            dish.Tastiness = newDish.Tastiness;
            dish.Calories = newDish.Calories;
            dish.Description = newDish.Description;
            dish.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            // Handle unsuccessful validations
            return View("Edit", newDish);
        }
    }

    [HttpPost("{id}/destroy")]
    public IActionResult Destroy(int id)
    {
        Dish? DishToDelete = _context.Dishes.SingleOrDefault(i => i.DishId == id);
        _context.Dishes.Remove(DishToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }


    [HttpPost("create")]
    public IActionResult Create(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("New");
        }
    }


[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public IActionResult Error()
{
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}

}

