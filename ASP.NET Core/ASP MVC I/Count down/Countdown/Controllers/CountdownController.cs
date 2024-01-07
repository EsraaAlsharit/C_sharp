// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Countdown.Controllers;

public class CountdownController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        DateTime CurrentTime = DateTime.Now;
        ViewBag.startTime = CurrentTime.ToString("MMM dd, yyyy hh:mm tt");
        DateTime BD = new DateTime(2024, 11, 27);
        ViewBag.endTime = BD.ToString("MMM dd, yyyy hh:mm tt");

        TimeSpan t = BD - CurrentTime;
        int NrOfDays = (int)t.TotalDays;

        int NrOfHours = (int)(t.TotalHours- (NrOfDays * 24) );

        Console.WriteLine(NrOfHours);
        Console.WriteLine(t.TotalMinutes);

        int NrOfMinutes = (int)(t.TotalMinutes- (((NrOfDays * 24)*60)+ (NrOfHours * 60)));

        ViewBag.RemainingDay = NrOfDays;
        ViewBag.RemainingHours = NrOfHours;
        ViewBag.RemainingMinutes = NrOfMinutes;

        return View("index");
    }




}
