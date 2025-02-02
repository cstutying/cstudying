using Microsoft.AspNetCore.Mvc;

namespace CSharp.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
  [HttpGet("")]
  // [ApiKey]
  public IActionResult Get()
  {
    return Ok();
  }
}