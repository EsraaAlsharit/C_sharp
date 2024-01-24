using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message = "This tutorial shows you how to add space in HTML.";
        return View("Index", message);
    }

    public IActionResult Numbers()
    {
        int[] Numbers = [1, 2, 10, 21, 7, 8, 3];
        return View(Numbers);
    }

    public IActionResult User()
    {
        Username user = new Username()
        {
            FristName = "Esraa",
            LastName = "Alsharit"
        };
        return View(user);
    }
    public IActionResult Users()
    {
        List<Username> users = new List<Username>();
        users.Add(new Username
        {
            FristName = "Esraa",
            LastName = "Alsharit"
        });
        users.Add(new Username
        {
            FristName = "Nick",
            LastName = "Morgan"
        });
        users.Add(new Username
        {
            FristName = "Ace",
            LastName = "Portgas"
        });

        users.Add(new Username { FristName = "Sara", LastName = "Jasm" });
        
        return View(users);

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
