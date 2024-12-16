using System;
using CSharp.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      const string connectionString =
        "Server=DESKTOP-6DDLMCG\\SQLEXPRESS;Database=CSharp;Trusted_Connection=True;TrustServerCertificate=True;";

      using (var connection = new SqlConnection(connectionString))
      {
        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
        foreach (var category in categories)
        {
          Console.WriteLine($"{category.Id} - {category.Id}");
        }
      }
      Console.WriteLine("Ola");
    }
  }
}