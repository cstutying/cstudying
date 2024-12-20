using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
        "Server=DESKTOP-ON9P9QD\\SQLEXPRESS;Database=CSharp;Trusted_Connection=True;TrustServerCertificate=True;";

      using (var connection = new SqlConnection(connectionString))
      {
        // CreateCategory(connection); // CHAMANDO METODO CREATE DE CATEGORY
        // CreateManyCategory(connection); // CHAMANDO METODO MANY CATEGORIA
        // UpdateCategory(connection); // CHAMANDO METODO LISTA DE UPDATE
        // DeleteCategory(connection); // 
        // ListCategories(connection); // CHAMANDO METODO LISTA DE CATEGORIES
        // GetCategory(connection); //
        // ExecuteProcedure(connection); // CHAMANDO METODO EXECUTE PROCEDURE
        // ExecuteReadProcedure(connection); // CHAMANDO METODO EXECUTE READ PROCEDURE
        // ExecuteScalar(connection); // CHAMANDO METODO EXECUTE SCALAR
        // ReadView(connection); // CHAMANDO METODO READ VIEW
        // OneToOne(connection); // CHAMANDO METODO ONE TO ONE
        // OneToMany(connection); // CHAMANDO METODO ONE TO MANY
        // QueryMutiple(connection); // CHAMANDO METODO QUERY MUTIPLE MANY TO MANY 
        SelectIn(connection); // CHAMANDO METODO SELECT IN
        // Like(connection, "backend"); // CHAMANDO METODO Like
        // Transaction(connection); // CHAMANDO METODO TRANSACTION

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

    //  CRIAÇÃO DA EXECUTE READ PROCEDURE (8-METODO)
    static void ExecuteReadProcedure(SqlConnection connection)
    {
      var procedure = "spGetCoursesByCategory";
      var pars = new { CategoryId = "09ce0b7b-cfca-497b-92c0-3290ad9d5142" };
      var courses = connection.Query(
        procedure,
        pars,
        commandType: CommandType.StoredProcedure);

      foreach (var item in courses)
      {
        Console.WriteLine(item.Title);
      }
    }

    // CRIAÇÃO DA EXECUTE SCALAR (9-METODO)
    static void ExecuteScalar(SqlConnection connection)
    {
      var category = new Category();
      category.Title = "Amazon AWS";
      category.Url = "amazon";
      category.Description = "Categoria destina a serviços do AWS";
      category.Order = 8;
      category.Summary = "AWS Cloud";
      category.Featured = false;

      var insertSql = @"
          INSERT INTO 
              [Category] 
          OUTPUT inserted.[Id]
          VALUES (
              NEWID(), 
              @Title, 
              @Url, 
              @Summary, 
              @Order, 
              @Description, 
              @Featured)";

      // EXECUTANDO QUERY (insertSql)
      var id = connection.ExecuteScalar<Guid>(insertSql, new
      {
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured,
      });
      Console.WriteLine($"A categoria inserida foi: {id}");
    }

    // CRIAÇÃO DA READ VIEW (10-METODO)
    static void ReadView(SqlConnection connection)
    {
      var sql = "SELECT * FROM [vwCourses]";
      var courses = connection.Query(sql);
      foreach (var item in courses)
      {
        Console.WriteLine($"{item.Id} - {item.Title}");
      }
    }

    // CRIAÇÃO DE ONE TO ONE (11-METODO)
    static void OneToOne(SqlConnection connection)
    {
      var sql = @"
          SELECT 
             *
          FROM
             [CareerItem] 
          INNER JOIN [Course] ON [CareerItem].[CourseId]=[Course].[Id]";

      var items = connection.Query<CareerItem, Course, CareerItem>(
        sql,
        (careerItem, course) =>
        {
          careerItem.Course = course;
          return careerItem;
        }, splitOn: "Id");

      foreach (var item in items)
      {
        Console.WriteLine($"{item.Title} - Curso: {item.Course?.Title}");
      }
    }

    // CRIAÇÃO DE ONE TO MANY (12-METODO)
    static void OneToMany(SqlConnection connection)
    {
      var sql = @"
      SELECT 
          [Career].[Id], 
          [Career].[Title],
          [CareerItem].[CareerId], 
          [CareerItem].[Title]
        FROM
          [Career]
        INNER JOIN
          [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
        ORDER BY 
          [Career].[Title]";

      var careers = new List<Career>();
      var items = connection.Query<Career, CareerItem, Career>(
        sql,
        (career, item) =>
        {
          var car = careers.Where(x => x.Id == career.Id).FirstOrDefault();
          if (car == null)
          {
            car = career;
            car.Items.Add(item);
            careers.Add(car);
          }
          else
          {
            car.Items.Add(item);
          }
          return career;
        }, splitOn: "CareerId");

      foreach (var career in careers)
      {
        Console.WriteLine($"{career.Title}");
        foreach (var item in career.Items)
        {
          Console.WriteLine($" - {item.Title}");
        }
      }
    }

    // CRIAÇÃO QUERY MUTIPLE MANY TO MANY (13-METODO)
    static void QueryMutiple(SqlConnection connection)
    {
      var query = "SELECT * FROM [Category]; SELECT * FROM [Course]";

      using (var multi = connection.QueryMultiple(query))
      {
        var categories = multi.Read<Category>();
        var courses = multi.Read<Course>();

        foreach (var item in categories)
        {
          Console.WriteLine(item.Title);
        }

        foreach (var item in courses)
        {
          Console.WriteLine(item.Title);
        }
      }
    }

    // CRIAÇÃO DO SELECT IN (14-METODO)
    static void SelectIn(SqlConnection connection)
    {
      var query = @"select * from Career where [Id] IN @Id";

      var items = connection.Query<Career>(query, new
      {
        Id = new[]{
            "4327ac7e-963b-4893-9f31-9a3b28a4e72b",
            "e6730d1c-6870-4df3-ae68-438624e04c72"
        }
      });
      foreach (var item in items)
      {
        Console.WriteLine(item.Title);
      }
    }

    // CRIAÇÃO DO LIKE (15-METODO)
    static void Like(SqlConnection connection, string term)
    {
      var query = @"SELECT * FROM [Course] WHERE [Title] LIKE @exp";

      var items = connection.Query<Course>(query, new
      {
        exp = $"%{term}%"
      });

      foreach (var item in items)
      {
        Console.WriteLine(item.Title);
      }
    }

    // CRIAÇÃO DO TRANSACTION (16-METODO)
    static void Transaction(SqlConnection connection)
    {
      var category = new Category();
      category.Id = Guid.NewGuid();
      category.Title = "Minha categoria que não";
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

      connection.Open();
      using (var transaction = connection.BeginTransaction())
      {
        var rows = connection.Execute(insertSql, new
        {
          category.Id,
          category.Title,
          category.Url,
          category.Summary,
          category.Order,
          category.Description,
          category.Featured,
        }, transaction);

        transaction.Commit();
        // transaction.Rollback();

        Console.WriteLine($"{rows} linha inserida");
      }
    }
  }
}