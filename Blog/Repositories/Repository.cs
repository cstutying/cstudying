using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class Repository<TModel> where TModel : class
  {
    private readonly SqlConnection _connection;
    // CRIAÇÃO DE Repository (0-METODO)
    public Repository(SqlConnection connection)
       => _connection = connection;

    // CRIAÇÃO DE T MODEL (1-METODO)
    public IEnumerable<TModel> Get()
      => _connection.GetAll<TModel>();
  }
}