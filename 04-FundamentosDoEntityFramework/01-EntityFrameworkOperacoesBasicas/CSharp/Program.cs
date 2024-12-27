using CSharp.Data;
using CSharp.Models;
using System.Linq;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;

namespace CSharp;

class Program
{
  static void Main(string[] args)
  {
    using var context = new CSharpDataContext();

    var user = new User
    {
      Name = "Christian",
      Slug = "christian",
      Email = "christian@gmail.com",
      Bio = "Studying C#",
      Image = "https://github.com/christian.png",
      PasswordHash = "123456"
    };


    var category = new Category
    {
      Name = "Backend",
      Slug = "backend"
    };


    var post = new Post
    {
      Author = user,
      Category = category,
      Body = "<p>Ola Mundo</p>",
      Slug = "iniciando-com-ef-core",
      Summary = "Neste artigo vamos aprender EF core",
      Title = "Começando com EF core",
      CreateDate = DateTime.Now,
      LastUpdateDate = DateTime.Now
    };
    context.Posts.Add(post);
    context.SaveChanges();

    Console.ReadKey(); // Não deixa o terminal fechar
  }
}