using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Web;


using TheWall.Models;

namespace TheWall.Controllers;

public class CommentController : Controller
{
    private MyContext _context;

    private readonly ILogger<CommentController> _logger;

    public CommentController(ILogger<CommentController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [SessionCheck]
    public IActionResult Create(Comment NewComment)
    {
        if (ModelState.IsValid)
        {
            _context.Add(NewComment);
            _context.SaveChanges();

            return RedirectToAction("Index", "Message");
            // return RedirectToActionResult("Index", "Message", null);
            // return RedirectToAction("Show", new { id = NewMessage.MessageId });
        }
        else
        {
            Post post = new Post
            {
                AllMessages = _context.Messages.Include(g => g.Creator).ToList(),
            AllComments = _context.Comments.Include(g => g.Creator).Include(g => g.Message).ToList()
            };
            // return RedirectToActionResult("Index", "Message", null);

            return View("Index");
        }
    }


    [HttpPost("{id}/remove")]
    public IActionResult Remove(int id)
    {
        Comment?CommentToDelete = _context.Comments.SingleOrDefault(i => i.CommentId == id);
        _context.Comments.Remove(CommentToDelete);

        _context.SaveChanges();
        return RedirectToAction("Index", "Message");

    }

    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Find the session, but remember it may be null so we need int?
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            // Check to see if we got back null
            Console.WriteLine(userId == null);

            if (userId == null)
            {
                // Redirect to the Index page if there was nothing in session
                // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
