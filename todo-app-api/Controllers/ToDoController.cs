using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todo_app_api.Models.Entities;
using CRUD_APP.Models;


namespace todo_app_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ToDoController : Controller
    {

        private readonly ToDoDbContext _context;

        public ToDoController(ToDoDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetTasks")]
        public List<ToDo> GetTasks()
        {
            // Retrieve all tasks from the database
            var tasks = _context.Tasks.ToList();
            return tasks;
        }

        [HttpPost]
        public IActionResult AddToDoItem([FromBody] ToDo newToDo)
        {
            if (ModelState.IsValid)
            {
                // Add the new ToDo item to the database
                _context.Tasks.Add(newToDo);
                _context.SaveChanges();

                // Return the updated list of tasks
                var tasks = _context.Tasks.ToList();
                return Ok(tasks);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}

