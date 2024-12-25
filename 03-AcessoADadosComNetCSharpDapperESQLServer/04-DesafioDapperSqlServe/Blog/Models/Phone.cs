using Dapper.Contrib.Extensions;

namespace Blog.Models
{
  [Table("[Phones]")]
  public class Phone
  {
    public int Id { get; set; }
    public string? Number { get; set; }
  }
}