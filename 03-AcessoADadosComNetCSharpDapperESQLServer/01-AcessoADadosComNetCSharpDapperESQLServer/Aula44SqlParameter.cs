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
      // CONEXÃO COM BANCO DE DADOS
      const string connectionString =
        "Server=DESKTOP-6DDLMCG\\SQLEXPRESS;Database=CSharp;Trusted_Connection=True;TrustServerCertificate=True;";

      var category = new Category();
      category.Id = Guid.NewGuid();
      category.Title = "Amazon AWS";
      category.Url = "amazon";
      category.Description = "Categoria destina a serviços do AWS";
      category.Order = 8;
      category.Summary = "AWS Cloud";
      category.Featured = false;

      var insertSql = @"INSERT INTO 
              [Category] 
          VALUES (
              @Id, 
              @Title, 
              @Url, 
              @Summary, 
              @Order, 
              @Description, 
              @Featured)";

      using (var connection = new SqlConnection(connectionString))
      {
        // EXECUTANDO QUERY (insertSql)
        var rows = connection.Execute(insertSql, new
        {
          category.Id,
          category.Title,
          category.Url,
          category.Summary,
          category.Order,
          category.Description,
          category.Featured,
        });
        Console.WriteLine($"{rows} linhas inseridas");

        var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
        foreach (var item in categories)
        {
          Console.WriteLine($"{item.Id} - {item.Id}");
        }
      }
      Console.WriteLine("Ola");
    }
  }
}