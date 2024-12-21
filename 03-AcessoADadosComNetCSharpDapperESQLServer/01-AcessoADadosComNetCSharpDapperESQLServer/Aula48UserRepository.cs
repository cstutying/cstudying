using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class UserRepository
  {
    private readonly SqlConnection _connection;

    // CRIAÇÃO DE USER REPOSITORY (0-METODO)
    public UserRepository(SqlConnection connection)
      => _connection = connection;



    // CRIAÇÃO DE USER (2-METODO)
    public User Get(int id)
      => _connection.Get<User>(id);

    // CRIAÇÃO DO CREATE (3-METODO)
    public void Create(User user)
    {
      user.Id = 0;
      _connection.Insert<User>(user);
    }
  }
}