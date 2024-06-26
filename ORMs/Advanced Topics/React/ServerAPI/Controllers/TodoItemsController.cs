using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerAPI.Models;

namespace ServerAPI.Controllers
{
    [Route("api/TodoItems")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private TodoContext _context;
        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // code above removed for brevity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }
        // code below removed for brevity

        // code above removed for brevity
        // Notice we specify the need for an id here. The whole route would be /api/todoitems/2 for example
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            // Find the item in question
            var todoItem = await _context.TodoItems.FindAsync(id);
            // Check to see if we got back null, in which case return NotFound
            if (todoItem == null)
            {
                return NotFound();
            }
            // Otherwise, return the item
            return todoItem;
        }
        // code below removed for brevity
        // code above removed for brevity
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem([FromBody] TodoItem todoItem)
        {
            // todoItem
            Console.WriteLine(todoItem);
            if (ModelState.IsValid)
            {
                _context.TodoItems.Add(todoItem);
                await _context.SaveChangesAsync();
                // This uses the GetTodoItem route we wrote above
                return CreatedAtAction(
                    nameof(GetTodoItem),
                    new { id = todoItem.Id },
                    todoItem);
            }
            else
            {
                // This is what will allow us to get error messages for our front end
                return BadRequest(ModelState);
            }
        }

        [HttpPost("update/{id}")]
        public async Task<IActionResult> UpdateTodoItem(long id, [FromBody] TodoItem todoItem)
        {
            // If the id from the route doesn't match the id of the item we passed along, throw a bad request
            if (id != todoItem.Id)
            {
                return BadRequest();
            }
            // Find the original item
            var originalTodoItem = await _context.TodoItems.FindAsync(id);
            // Verify the original item exists
            if (originalTodoItem == null)
            {
                return NotFound();
            }
            // Added to update item
            originalTodoItem.Name = todoItem.Name;
            originalTodoItem.IsComplete = todoItem.IsComplete;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!TodoItemExists(id))
            {
                return NotFound();
            }
            return NoContent();
        }
        // code below removed for brevity
        [HttpPost("delete/{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool TodoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }

    }


}