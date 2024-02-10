using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("Login")]

    public IActionResult Login(string name)
    {
        Console.WriteLine(name == null);
        Console.WriteLine(name);
        if (name == null)
        {
            ViewBag.err = "name is required";
            // return RedirectToAction("Index");
            return View("Index");

        }
        else
        {
            HttpContext.Session.SetString("name", name);//make or set session string 
            HttpContext.Session.SetInt32("number", 22);//make or set session string 
            return RedirectToAction("Dashboard");
        }

    }
    [HttpGet("Logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
    public IActionResult Dashboard()
    {
        // string? name = HttpContext.Session.GetString("name");
        // Console.WriteLine(name);
        if (!string.IsNullOrEmpty(HttpContext.Session.GetString("name")))
        // if (name!=null)
            return View();
        else
            return RedirectToAction("Index");

    }
    [HttpPost("Home/operations")]
    public IActionResult Operations(string operation)
    {
        // Console.WriteLine(operation);

        int? number = HttpContext.Session.GetInt32("number");

        int value = (int)number;
        switch (operation)
        {
            case "+1":
                value++;
                break;
            case "-1":
                value--;
                break;
            case "x2":
                value *= 2;
                break;
            case "+ Random":
                Random rand = new Random();
                value += rand.Next(1, 100);
                // code block
                break;
        }

        Console.WriteLine(value);


        HttpContext.Session.SetInt32("number", value);//make or set session string 

        return RedirectToAction("Dashboard");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
