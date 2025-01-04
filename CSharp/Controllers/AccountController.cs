using CSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
  [HttpPost("v1/login")]
  public IActionResult Login([FromServices] TokenService tokenService)
  {
    var token = tokenService.GenerateToken(null);
    return Ok(token);
  }
}