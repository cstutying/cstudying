using CSharp.Data;
using CSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharp.Controllers;

[ApiController]
public class CategoryController : ControllerBase
{
  [HttpGet("v1/categories")]
  public async Task<IActionResult> GetAsync(
    [FromServices]CSharpDataContext context)
  {
    var categories = await context.Categories.ToListAsync();
    return Ok(categories);
  }
  
  [HttpGet("v1/categories/{id:int}")]
  public async Task<IActionResult> GetByIdAsync(
    [FromRoute] int id,
    [FromServices]CSharpDataContext context)
  {
    var category = await context
      .Categories
      .FirstOrDefaultAsync(x => x.Id == id);

    if (category == null)
      return NotFound();
    
    return Ok(category);
  }
  
  [HttpPost("v1/categories")]
  public async Task<IActionResult> PostAsync(
    [FromBody] Category model,
    [FromServices]CSharpDataContext context)
  {
    try
    {
      await context.Categories.AddAsync(model);
      await context.SaveChangesAsync();

      return Created($"v1/categories/{model.Id}", model);
    }
    catch (DbUpdateException ex)
    {
      return StatusCode(500, "05XE8 - Não foi possível incluir a categoria");
    }
    catch(Exception e)
    {
      return StatusCode(500,"05XE9 - Falha interna no servidor");
    }
  }
  
  [HttpPut("v1/categories/{id:int}")]
  public async Task<IActionResult> PutAsync(
    [FromRoute]int id,
    [FromBody] Category model,
    [FromServices]CSharpDataContext context)
  {
    var category = await context
      .Categories
      .FirstOrDefaultAsync(x => x.Id == id);
    
    if(category == null)
      return NotFound();

    category.Name = model.Name;
    category.Slug = model.Slug;

    context.Categories.Update(category);
    await context.SaveChangesAsync();
    
    return Ok(model);
  }
  
  [HttpDelete("v1/categories/{id:int}")]
  public async Task<IActionResult> DeleteAsync(
    [FromRoute]int id,
    [FromServices]CSharpDataContext context)
  {
    var category = await context
      .Categories
      .FirstOrDefaultAsync(x => x.Id == id);
    
    if(category == null)
      return NotFound();

    context.Categories.Remove(category);
    await context.SaveChangesAsync();
    
    return Ok(category);
  }
}