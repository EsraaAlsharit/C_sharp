// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

public class HelloController : Controller
{
    //prop
    public string Name { get; set; }
    public string Location { get; set; }
    public string Languge { get; set; }
    public string Comment { get; set; }



    [HttpGet("")]
    public IActionResult Index()
    {
        return View("index");
    }


    //Level 2
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

        //Level 2
        // this.Name = name;
        // this.Location = location;
        // this.Languge = languge;
        // this.Comment = comment;
        // return RedirectToAction("Details");

        ViewBag.name = Name;
        ViewBag.loc = Location;
        ViewBag.lan = Languge;
        ViewBag.com = Comment;
        return View("details");


    }
}
