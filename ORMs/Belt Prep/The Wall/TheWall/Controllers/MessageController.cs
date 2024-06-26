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

public class MessageController : Controller
{
    private MyContext _context;

    private readonly ILogger<MessageController> _logger;

    public MessageController(ILogger<MessageController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [SessionCheck]
    public IActionResult Index()
    {
        // List<Messages> AllMessages = _context.Messages.ToList();
        Post post = new Post
        {
            AllMessages = _context.Messages.Include(g => g.Creator).ToList(),
            AllComments = _context.Comments.Include(g => g.Creator).Include(g => g.Message).ToList()
        };
        // List<Message> AllMessages = _context.Messages.Include(g => g.Creator).ToList();

        // List<Comment> AllMessages = _context.Comment.Include(g => g.Guests).ThenInclude(g => g.User).ToList();

        return View(post);

    }

    [SessionCheck]
    public IActionResult Create(Message NewMessage)
    {
        if (ModelState.IsValid)
        {
            _context.Add(NewMessage);
            _context.SaveChanges();

            return RedirectToAction("Index");
            // return RedirectToAction("Show", new { id = NewMessage.MessageId });
        }
        else
        {
               Post post = new Post
        {
            AllMessages = _context.Messages.Include(g => g.Creator).ToList(),
            AllComments = _context.Comments.Include(g => g.Creator).Include(g => g.Message).ToList()
        };
            return View("Index", post);
        }
    }


    [HttpPost("{id}/destroy")]
    public IActionResult Destroy(int id)
    {
        Message? MessageToDelete = _context.Messages.SingleOrDefault(i => i.MessageId == id);
        _context.Messages.Remove(MessageToDelete);

        _context.SaveChanges();
        return RedirectToAction("Index");

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
