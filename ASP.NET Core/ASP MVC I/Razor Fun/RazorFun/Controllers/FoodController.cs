
using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers;

public class FoodController : Controller
{

    [HttpGet("")]
    public ViewResult index()
    {
        return View("Index");
    }
}