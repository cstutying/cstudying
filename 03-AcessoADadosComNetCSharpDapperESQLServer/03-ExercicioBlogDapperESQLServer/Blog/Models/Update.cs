using Dapper.Contrib.Extensions;

namespace Blog.Models
{
  [Table("[Update]")]
  public class Update
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
  }
}