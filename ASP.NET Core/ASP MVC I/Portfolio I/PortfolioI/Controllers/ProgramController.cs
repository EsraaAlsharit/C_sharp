// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PortfolioI.Controllers;

// public class HelloController : Controller   // Remember inheritance?    
// {
//     [HttpGet] // We will go over this in more detail on the next page    
//     [Route("")] // We will go over this in more detail on the next page
//     public string Index()
//     {
//         return "Hello World from HelloController!";
//     }
// }

public class ProgramController : Controller
{
    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "This is my Index!";
    }
    // Route declaration Option B
    // This will go to "localhost:5XXX/user/more"
    [HttpGet("projects")]
    public string projects()
    {
        return "These are my projects!";
    }

    [HttpGet("contact")]
    public string contact()
    {
        return "This is my Contact!";
    }

}
