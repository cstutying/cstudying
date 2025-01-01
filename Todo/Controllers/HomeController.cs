using Todo.Data;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
  [HttpGet("/")]
  public string Get()
  {
    using (var context = new AppDbContext())
    {

    }
    return "Hello World";
  }
}