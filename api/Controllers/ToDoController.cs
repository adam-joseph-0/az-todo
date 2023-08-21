using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace az_todo.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoController : ControllerBase
{

    private static List<string> ToDos = new List<string> {
        "first todo"
    };

    private readonly ILogger<ToDoController> _logger;

    public ToDoController(ILogger<ToDoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetToDos")]
    public IEnumerable<string> Get()
    {
        return ToDos;
    }

    [HttpPost(Name = "PostTodo")]
    public string Post(string todo)
    {
        ToDos.Add(todo);

        return todo;
    }
}
