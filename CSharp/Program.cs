using System;
using System.Data;
using CSharp.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CSharp
{
  class Program
  {
    // MAIN (0-METODO)
    static void Main(string[] args)
    {
      // CONEXÃO COM BANCO DE DADOS
      const string connectionString =
        "Server=DESKTOP-6DDLMCG\\SQLEXPRESS;Database=CSharp;Trusted_Connection=True;TrustServerCertificate=True;";

      using (var connection = new SqlConnection(connectionString))
      {
        // CreateCategory(connection); // CHAMANDO CREATE DE CATEGORY
        // CreateManyCategory(connection); // CHAMANDO MANY CATEGORIA
        // UpdateCategory(connection); // CHAMANDO LISTA DE UPDATE
        // DeleteCategory(connection); // 
        // ListCategories(connection); // CHAMANDO LISTA DE CATEGORIES
        // GetCategory(connection);
        ExecuteProcedure(connection); // CHAMANDO EXECUTE PROCEDURE
      }
    }

    // LISTA DE CATEGORIAS (1-METODO)
    static void ListCategories(SqlConnection connection)
    {
      var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
      foreach (var item in categories)
      {
        Console.WriteLine($"{item.Id} - {item.Title}");
      }
    }

    // GET DA CATEGORIA (2-METODO)
    static void GetCategory(SqlConnection connection)
    {
      var category = connection.QuerySingle<Category>("SELECT [Id], [Title] FROM [Category] WHERE [Id]=@id", new { id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4") });
      Console.WriteLine($"{category.Id} - {category.Title}");
    }

    // CRIAÇÃO DA CATEGORIA (3-METODO)
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

    // UPDATE DA CATEGORIA (4-METODO)
    static void UpdateCategory(SqlConnection connection)
    {
      var UpdateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@id";
      var rows = connection.Execute(UpdateQuery, new
      {
        id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
        title = "Frontend 2024"
      });

      Console.WriteLine($"{rows} registro atualizado");
    }

    // DELETE DA CATEGORIA (5-METODO)
    static void DeleteCategory(SqlConnection connection)
    {
      var DeleteQuery = "DELETE [Category] SET [Title]=@title WHERE [Id]=@id";
      var rows = connection.Execute(DeleteQuery, new
      {
        id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
        title = "Frontend 2024"
      });
      Console.WriteLine($"{rows} linha removida");
    }

    // CRIAÇÃO DA MANY CATEGORIA (6-METODO)
    static void CreateManyCategory(SqlConnection connection)
    {
      var category = new Category();
      category.Id = Guid.NewGuid();
      category.Title = "Amazon AWS";
      category.Url = "amazon";
      category.Description = "Categoria destina a serviços do AWS";
      category.Order = 8;
      category.Summary = "AWS Cloud";
      category.Featured = false;

      var category2 = new Category();
      category2.Id = Guid.NewGuid();
      category2.Title = "Categoria Nova";
      category2.Url = "categoria-nova";
      category2.Description = "Categoria destina nova";
      category2.Order = 9;
      category2.Summary = "Categoria";
      category2.Featured = true;

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
      var rows = connection.Execute(insertSql, new[] {
          new
          {
            category.Id,
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured,
          },
          new
          {
            category2.Id,
            category2.Title,
            category2.Url,
            category2.Summary,
            category2.Order,
            category2.Description,
            category2.Featured,
          }
       });
      Console.WriteLine($"{rows} linhas inseridas");
    }

    // CRIAÇÃO DA EXECUTE PROCEDURE (7-METODO)
    static void ExecuteProcedure(SqlConnection connection)
    {
      var procedure = "spDeleteStudent";
      var pars = new { StudentId = "4e9ba755-9e8b-4805-a385-e02adb75b8d6" };
      var affectedRows = connection.Execute(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

      Console.WriteLine($"{affectedRows} linha afetada");
    }

    // 

  }
}