using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveywithModel.Models;

namespace DojoSurveywithModel.Controllers;

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


    [HttpPost("results")]
    public IActionResult Process(Survey survey)
    {
        Console.WriteLine(survey.Name);
        Console.WriteLine(survey.Location);
        Console.WriteLine(survey.Languge);
        Console.WriteLine(survey.Comment);

        Survey newSurvey = new Survey()
        {
            Name = survey.Name,
            Location = survey.Location,
            Languge=survey.Languge,
            Comment=survey.Comment
        };
        return View("Details", newSurvey);
    }

    public IActionResult Privacy()
    {
        
        return View();
    }
    // public IActionResult Details()
    // {
        
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
