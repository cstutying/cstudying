using Microsoft.AspNetCore.Mvc;

namespace CSharp.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
  [HttpGet("")]
  public IActionResult Get()
  {
    return Ok();
  }
}