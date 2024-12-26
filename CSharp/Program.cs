using CSharp.Data;
using CSharp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CSharp;

class Program
{
  static void Main(string[] args)
  {
    using (var context = new CSharpDataContext())
    {
      // CREATE
      // var tag2 = new Tag { Name = "ASP.NET", Slug = "dotnet" };
      // context.Tags.Add(tag2);
      // context.SaveChanges();
      //
      // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
      // context.Tags.Add(tag);
      // context.SaveChanges();

      // UPDATE
      // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
      // tag.Name = ".NET";
      // tag.Slug = "dotnet";

      // context.Update(tag);
      // context.SaveChanges();

      // DELETE
      // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

      // context.Remove(tag);
      // context.SaveChanges();

      // REMOVE
      // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

      // context.Remove(tag);
      // context.SaveChanges();

      // READ
      // var tags = context
      //   .Tags
      //   .AsNoTracking()
      //   .ToList();  

      // foreach (var tag in tags)
      // {
      //   Console.WriteLine(tag.Name);
      // }

      // var tag = context
      //   .Tags
      //   .AsNoTracking()
      //   .FirstOrDefault(x => x.Id == 3);

      // tag.Name = "Ponto NET";
      // tag.Slug = "dotnet";

      // context.Update(tag);
      // context.SaveChanges();
      var tag = context
        .Tags
        .AsNoTracking()
        .FirstOrDefault(x => x.Id == 13);

      Console.WriteLine(tag.Name);
      Console.ReadKey(); // Não deixa o terminal fechar
    }
  }
}