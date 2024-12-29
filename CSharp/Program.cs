using CSharp.Data;
using CSharp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CSharp;

class Program
{
  static void Main(string[] args)
  {
    using var context = new CSharpDataContext();
    var post = context.Posts.FirstOrDefault(X => X.Id == 1);
    var posts2 = context.Posts.AsNoTracking();

    Console.ReadKey(); // Não deixa o terminal fechar
  }
}