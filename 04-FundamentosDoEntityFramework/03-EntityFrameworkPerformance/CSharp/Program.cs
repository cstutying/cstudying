using System.ComponentModel.Design;
using CSharp.Data;
using CSharp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CSharp;

class Program
{
  static async Task Main(string[] args)
  {
    using var context = new CSharpDataContext();
    Console.WriteLine("Teste");

    var posts = context.PostWithTagsCounts.ToList();
    foreach (var item in posts)
    {
      item.Count();
    }

    Console.ReadKey(); // Não deixa o terminal fechar
  }
}