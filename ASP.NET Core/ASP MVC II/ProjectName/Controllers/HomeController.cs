using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetString("Username", "Esoo_chan");//make or set session string 
        HttpContext.Session.SetInt32("age", 27);//make or set session int

        // int mynumber = 7;
        Friend myfirend = new Friend()
        {
            FristName = "Esraa",
            LastName = "Alsharit"
        };
        // return View(mynumber);
        return View(myfirend);
    }

    public IActionResult Privacy()
    {

        //setString()//update
        string? userName = HttpContext.Session.GetString("Username");//get session
        int? age = HttpContext.Session.GetInt32("age");//get int session
        //if i want to make operation on the int sesstion i should type cost it 
        //becouse int != int?
        return View("Privacy",userName);
    }
    public IActionResult Register()
    {
        Console.WriteLine("Register");

        return View();
    }
    public IActionResult User()
    {
        return View();
    }
    [HttpGet("clear")]
    public IActionResult ClearSesstion()
    {
        HttpContext.Session.Clear();//all of the sessions
        return RedirectToAction("Index");
    }

    [HttpPost("Home/registerWizard")]
    // public IActionResult RegisterWizard(string name, string house, int year)
    // {    
    //     // process the form...
    //     Console.WriteLine("new");
    //     Console.WriteLine(name);
    //     Console.WriteLine(house);
    //     Console.WriteLine(year);
    //         return RedirectToAction("Index");
    // }


    public IActionResult RegisterWizard(HogwartsStudent student) // updated
    {
        // process the form...
        // You can start by logging the data to the console
        // or using the debugger to inspect the HogwartsStudent instance!
        Console.WriteLine(student.Name);
        Console.WriteLine(student.House);
        Console.WriteLine(student.CurrentYear);

        return RedirectToAction("Index");
    }

    [HttpPost("Home/User")]
    public IActionResult NewUser(User user) // updated
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Password);
            // Do somethng! Maybe insert into a database or log data to the console  
            // Then we will redirect to a new page        
            return RedirectToAction("Index");
        }
        else
        {
            // Oh no! We need to return a ViewResponse to preserve the ModelState and the errors it now contains! 
            // Make sure you return the View that contains the form!       
            return View("User");

        }

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
