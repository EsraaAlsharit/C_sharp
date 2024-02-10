using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

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

    [HttpPost("new")]
    public IActionResult NewUser(User user)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.DOB);
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Number);
            return RedirectToAction("Success");
        }
        else
        {
            return View("Index");
        }
    }

    public IActionResult Success()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
