using System;
using System.ComponentModel;
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
      // ReadUsers(); // CHAMANDO METODO READ USERS
      // ReadUser(); // CHAMANDO METODO READ USER
      // CreateUser(); // CHAMANDO METODO CREATE USER
      // UpdateUser(); // CHAMANDO METODO UPDATE USER
      // DeleteUser(); // CHAMANDO METODO DELETE USER
    }

    // CRIAÇÃO DE READ USERS (1-METODO)
    public static void ReadUsers()
    {
      var repository = new UserRepository();
      var users = repository.Get();

      foreach (var user in users)
      {
        Console.WriteLine(user.Name);
      }
    }

    // CRIAÇÃO DE READ USER (2-METODO)
    public static void ReadUser()
    {
      using (var connection = new SqlConnection(CONNECTION_STRING))
      {
        var user = connection.Get<User>(1);
        Console.WriteLine(user.Name);
      }
    }

    // CRIAÇÃO DE CREATE USER (3-METODO)
    public static void CreateUser()
    {
      var user = new User()
      {
        Bio = "Equipe Christian.io",
        Email = "Equipe Christian.io",
        Image = "https://...",
        Name = "Equipe christian.io",
        PasswordHash = "HASH",
        Slug = "equipe-christian"
      };

      using (var connection = new SqlConnection(CONNECTION_STRING))
      {
        connection.Insert<User>(user);
        Console.WriteLine("Cadastro realizado com sucesso");
      }
    }

    // CRIAÇÃO DE UPDATE USER (4-METODO)
    public static void UpdateUser()
    {
      var user = new User()
      {
        Id = 2,
        Bio = "Equipe | Christian.io",
        Email = "Equipe Christian.io",
        Image = "https://...",
        Name = "Equipe de suporte christian.io",
        PasswordHash = "HASH",
        Slug = "equipe-christian"
      };

      using (var connection = new SqlConnection(CONNECTION_STRING))
      {
        connection.Update<User>(user);
        Console.WriteLine("Atualização realizada com sucesso");
      }
    }

    // CRIAÇÃO DE DELETE USER (5-METODO)
    public static void DeleteUser()
    {

      using (var connection = new SqlConnection(CONNECTION_STRING))
      {
        var user = connection.Get<User>(2);
        connection.Delete<User>(user);
        Console.WriteLine("Exclusão Realizada com sucesso");
      }
    }
  }
}