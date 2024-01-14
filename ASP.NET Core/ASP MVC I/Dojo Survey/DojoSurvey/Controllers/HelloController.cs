// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

public class HelloController : Controller
{
    string Name="";
    string Location="";
    string Languge="";
    string Comment="";



    [HttpGet("")]
    public IActionResult Index()
    {
        return View("index");
    }


    [HttpGet("details")]
    public IActionResult Details()
    {
    Console.WriteLine("hi in the details");

        ViewBag.name = Name;
        ViewBag.loc = Location;
        ViewBag.lan = Languge;
        ViewBag.com = Comment;
        return View("details");
    }




    [HttpPost("results")]
    public IActionResult Results(string name, string location, string languge, string comment)
    {
        this.Name = name;
        this.Location = location;
        this.Languge = languge;
        this.Comment = comment;

        return RedirectToAction("Details");

        // return View("details");

    }
}
