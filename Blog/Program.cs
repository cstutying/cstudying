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
      var connection = new SqlConnection(CONNECTION_STRING);
      connection.Open();

      ReadUsers(connection); // CHAMANDO METODO READ USERS
      ReadRoles(connection); // CHAMANDO METODO READ ROLES

      connection.Close();
    }

    // CRIAÇÃO DE READ USERS (1-METODO)
    public static void ReadUsers(SqlConnection connection)
    {
      var repository = new Repository<User>(connection);
      var users = repository.Get();

      foreach (var user in users)
        Console.WriteLine(user.Name);
    }

    // CRIAÇÃO DE READ ROLES (2-METODO)
    public static void ReadRoles(SqlConnection connection)
    {
      var repository = new RoleRepository(connection);
      var roles = repository.Get();

      foreach (var role in roles)
        Console.WriteLine(role.Name);
    }
  }
}