using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace az_todo.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoController : ControllerBase
{
    private static List<ToDo> ToDos = new List<ToDo> {
        "first todo"
    };

    private readonly ILogger<ToDoController> _logger;

    public ToDoController(ILogger<ToDoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetToDos")]
    public IEnumerable<ToDo> Get()
    {
        return ToDos;
    }
}
