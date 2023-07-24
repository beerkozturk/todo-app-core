using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todo_app_api.Models.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todo_app_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ToDoController : Controller
    {
        List<ToDo> TodoList = new List<ToDo> {
                new ToDo {Id=1,Description="Yazılım alanında gelişimimi sağlamak için görev",Title="Günde 2 saat React bak",IsComplated=false},
                 new ToDo {Id=2,Description="Yazılım alanında gelişimi gördüm",Title="Günde 2 saat JS bak",IsComplated=false},



                };

        [HttpGet(Name = "GetToDos")]


        public List<ToDo> Index()
        {
            return TodoList;
        }
    }
}

