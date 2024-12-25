using Dapper.Contrib.Extensions;

namespace Blog.Models
{
  [Table("[Contact]")]
  public class Contact
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Number { get; set; }
    public string? Email { get; set; }
    public string? Date { get; set; }
    public string? Socials { get; set; }
  }
}