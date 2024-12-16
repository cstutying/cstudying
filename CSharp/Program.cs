using System;
using CSharp.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CSharp
{
  class Program
  {
    // MAIN
    static void Main(string[] args)
    {
      // CONEXÃO COM BANCO DE DADOS
      const string connectionString =
        "Server=DESKTOP-6DDLMCG\\SQLEXPRESS;Database=CSharp;Trusted_Connection=True;TrustServerCertificate=True;";

      using (var connection = new SqlConnection(connectionString))
      {
        // CHAMANDO LISTA DE CATEGORIES
        ListCategories(connection);
        // CreateCategory(connection); // CHAMANDO CREATE DE CATEGORY
      }
    }

    // LISTA DE CATEGORIAS (1METODO)
    static void ListCategories(SqlConnection connection)
    {
      var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
      foreach (var item in categories)
      {
        Console.WriteLine($"{item.Id} - {item.Id}");
      }
    }

    // CRIAÇÃO DA CATEGORIA (2METODO)
    static void CreateCategory(SqlConnection connection)
    {
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
    }

    // UPDATE DA CATEGORIA (3METODO)
    static void UpdateCategory(SqlConnection connection)
    {

    }
  }
}