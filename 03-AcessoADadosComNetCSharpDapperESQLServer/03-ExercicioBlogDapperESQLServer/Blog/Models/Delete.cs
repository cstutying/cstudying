using Dapper.Contrib.Extensions;

namespace Blog.Models
{
  [Table("[Delete]")]
  public class Delete
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
  }
}