using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveywithValidations.Models;

namespace DojoSurveywithValidations.Controllers;

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

        if (ModelState.IsValid)
        {
          Console.WriteLine(survey.Name);
        Console.WriteLine(survey.Location);
        Console.WriteLine(survey.Languge);
        Console.WriteLine(survey.Comment);

                Survey newSurvey = new Survey()
        {
            Name = survey.Name,
            Location = survey.Location,
            Languge = survey.Languge,
            Comment = survey.Comment
        };
              // Do somethng! Maybe insert into a database or log data to the console  
        // Then we will redirect to a new page        
        return View("Details",newSurvey); 
        }
        else
        {
            return View("Index");

        }

 
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
