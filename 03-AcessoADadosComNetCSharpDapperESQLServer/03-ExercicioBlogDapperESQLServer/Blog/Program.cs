using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
  class Program
  {
    private const string CONNECTION_STRING = "Server=DESKTOP-ON9P9QD\\SQLEXPRESS;Database=Blog;Trusted_Connection=True;TrustServerCertificate=True;";
    static void Main(string[] args)
    {
      var connection = new SqlConnection(CONNECTION_STRING);
      connection.Open();

      ReadUsersWithRoles(connection);
      // CreateUser(connection);
      // ReadRoles(connection);
      // ReadTags(connection);

      connection.Close();
    }

    // CRIAÇÃO DE CREATE READ USERS WITH ROLES (1-METODO)
    public static void ReadUsersWithRoles(SqlConnection connection)
    {
      var repository = new UserRepository(connection);
      var items = repository.GetWithRoles();

      foreach (var item in items)
      {
        Console.WriteLine(item.Name);
        foreach (var role in item.Roles)
        {
          Console.WriteLine($" - {role.Name}");
        }
      }
    }

    // CRIAÇÃO DE READ ROLES (2-METODO)
    public static void ReadRoles(SqlConnection connection)
    {
      var repository = new Repository<Role>(connection);
      var items = repository.Get();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }

    // CRIAÇÃO DE READ TAGS (3-METODO)
    public static void ReadTags(SqlConnection connection)
    {
      var repository = new Repository<Tag>(connection);
      var items = repository.Get();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }

    // CRIAÇÃO DE READ UPDATE (4-METODO)
    public static void ReadUpdate(SqlConnection connection)
    {
      var repository = new Repository<Update>(connection);
      var items = repository.Get();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }

    // CRIAÇÃO DE READ DELETE (5-METODO)
    public static void ReadDelete(SqlConnection connection)
    {
      var repository = new Repository<Delete>(connection);
      var items = repository.Get();

      foreach (var item in items)
        Console.WriteLine(item.Name);
    }

    // CRIAÇÃO DE CREATE USER (6-METODO)
    public static void CreateUser(SqlConnection connection)
    {
      var user = new User()
      {

        Email = "email@christian.com",
        Bio = "bio",
        Image = "imagem",
        Name = "Name",
        PasswordHash = "hash",
        Slug = "slug"
      };
      var repository = new Repository<User>(connection);
      repository.Create(user);
    }

  }
}