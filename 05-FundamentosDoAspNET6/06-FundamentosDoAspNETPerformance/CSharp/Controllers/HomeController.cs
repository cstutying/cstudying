using Microsoft.AspNetCore.Mvc;

namespace CSharp.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
  [HttpGet("")]
  // [ApiKey]
  public IActionResult Get(
    [FromServices]IConfiguration config)
  {
    var env = config.GetValue<string>("Env");
    return Ok(new
    {
      Environment = env
    });
  }
}