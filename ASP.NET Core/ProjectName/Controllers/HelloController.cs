// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace ProjectName.Controllers;

// public class HelloController : Controller   // Remember inheritance?    
// {
//     [HttpGet] // We will go over this in more detail on the next page    
//     [Route("")] // We will go over this in more detail on the next page
//     public string Index()
//     {
//         return "Hello World from HelloController!";
//     }
// }

// public class HelloController : Controller
// {
//     // Route declaration Option A
//     // This will go to "localhost:5XXX"
//     [HttpGet]
//     [Route("")]
//     public string Index()
//     {
//         return "Hello from the index";
//     }

//     // Route declaration Option B
//     // This will go to "localhost:5XXX/user/more"
//     [HttpGet("user/more")]
//     public string User()
//     {
//         return "Hello user";
//     }

//     //http://localhost:5217/greet/Esoo
//     [HttpGet("greet/{name}")]
//     public string Greet(string name)
//     {
//         return $"Hello {name}!";
//     }

//     [HttpGet("greet/{name}/{time}")]
//     // When testing the time input, use only whole numbers
//     public string GreetTime(string name, int time)
//     {
//         return $"Hello {name}! It is currently {time} o'clock!";
//     }

//     // Post request example
//     // This will go to "localhost:5XXX/submission"
//     [HttpPost]
//     [Route("submission")]
//     // Don't worry about what the form is doing for now. We'll get to those soon!
//     // Note: You will not be able to navigate to this route! This is for demonstration only!
//     public string FormSubmission(string formInput)
//     {
//         // Logic for post request here
//         return "I handled a request!";
//     }
// }


// public class HelloController : Controller
// {
//     [HttpGet]
//     [Route("")]
//     public ViewResult Index()
//     {
//         // will attempt to serve 
//         // Views/Hello/Index.cshtml
//         // or if that file isn't there:
//         // Views/Shared/Index.cshtml
//         return View();
//     }
//     [HttpGet]
//     [Route("info")]
//     public ViewResult Info()
//     {
//         // Same logic for serving a view applies
//         // if we provide the exact view name
//         return View("Info");
//     }
//     // You may also serve the same view twice from additional actions
//     [HttpGet("elsewhere")]
//     public ViewResult Elsewhere()
//     {
//         // This would be a case where we have to specify the file name
//         return View("Index");
//     }

// }

public class HelloController : Controller
{
    // Other code 
    [HttpGet("")]
    public IActionResult Index()
    {
        // Here we assign the value "Hello World!" to the key .Example    
        // Key names can be whatever you like    
        ViewBag.name = "Esoo";
        return View();
    }

    // Other code
    [HttpGet("here")]
    public ViewResult Here()
    {
        return View();
    }

    [HttpGet("redirect")]
    public RedirectToActionResult GoSomewhere()
    {
        // Notice how we reference capital H "Here" from the Action (method) name 
        // rather than "/here" from the route
        return RedirectToAction("Here");
    }

    [HttpGet("redirect")]
    public RedirectResult GoSomewhereRedirect()
    {
        // Notice we do not need to specify localhost:5XXX, just what comes after
        // If we wanted to redirect to the front page, we would write ("/")
        return Redirect("/here");
    }

    //not working 
    // [HttpGet("result")]
    // public RedirectToActionResult test()
    // {
    //     if(favoriteResponse == "Redirect")
    //     {
    //     	return RedirectToAction("Index");
    //    }else {
    //         // This route will require that an "ItDepends.cshtml" exists
    //     	return View("Hello");
    //     }
    // }
    //-----------------------------------------


//IActionResult it will return any type of View , RedirectToAction or RedirectToAction
//but the performance will be less than any other specific type of function
    [HttpGet("result/{favoriteResponse}")]
    public IActionResult ItDepends(string favoriteResponse)
    {
        if (favoriteResponse == "Redirect")
        {
            return RedirectToAction("Index");
        }
        else if (favoriteResponse == "Json")
        {
            return Json(new { favoriteResponse = favoriteResponse });
        }
        else
        {
            // This route will require that an "ItDepends.cshtml" exists
            return View();
        }
    }


    // remember to use [HttpPost]
[HttpPost("process")]
public IActionResult Process(string TextField, int NumberField)
{    
    // Do something with form input
    Console.WriteLine($"My text was: {TextField}");
    Console.WriteLine($"My number was: {NumberField}");
    // Then don't forget to return some kind of result!
    return RedirectToAction("Index");
}
}
