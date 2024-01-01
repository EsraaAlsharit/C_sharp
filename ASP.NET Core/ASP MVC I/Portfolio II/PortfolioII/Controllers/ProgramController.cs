// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PortfolioII.Controllers;

public class ProgramController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("index");
    }

    [HttpGet("projects")]
    public IActionResult Projects()
    {
        return View("projects");
    }

    [HttpGet("contact")]
    public IActionResult Contact()
    {
        return View("contact");
    }


}
