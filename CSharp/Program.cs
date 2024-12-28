using CSharp.Data;
using CSharp.Models;
using System.Linq;

namespace CSharp;

class Program
{
  static void Main(string[] args)
  {
    using var context = new CSharpDataContext();
    // Inseri um User
    context.Users.Add(new User
    {
      Bio = "Um pouco sobre mim",
      Email = "christian@csharp.com",
      Image = "https://github.com/christia.png",
      Name = "Christian CSharp",
      PasswordHash = "123456",
      Slug = "christian-csharp"
    });
    context.SaveChanges();

    // Estrutura para Inserir um Post
    var user = context.Users.FirstOrDefault();
    var post = new Post
    {
      Author = user,
      Body = "Exercício CSharp",
      Category = new Category
      {
        Name = "CSharp",
        Slug = "csharp"
      },
      CreateDate = System.DateTime.Now,
      Slug = "meu-artigo",
      Summary = "Neste artigo vamos conferir...",
      // Tags = null,
      Title = "Meu artigo",
    };

    context.Posts.Add(post);
    context.SaveChanges();
    Console.ReadKey(); // Não deixa o terminal fechar
  }
}