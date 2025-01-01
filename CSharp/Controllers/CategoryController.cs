using CSharp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Controllers;

[ApiController]
public class CategoryController : ControllerBase
{
  [HttpGet("categories")]
  public IActionResult Get(
    [FromServices]CSharpDataContext context)
  {
    var categories = context.Categories.ToList();
    return Ok(categories);
  }
}