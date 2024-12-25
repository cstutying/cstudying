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

    // CRIAÇÃO DE GET (2-METODO)
    public TModel Get(int id)
        => _connection.Get<TModel>(id);

    // CRIAÇÃO DO CREATE (3-METODO)
    public void Create(TModel model)
        => _connection.Insert<TModel>(model);

    // CRIAÇÃO DO UPDATE (4-METODO)
    public void Update(TModel model)
       => _connection.Update<TModel>(model);

    // CRIAÇÃO DO DELETE (5-METODO)
    public void Delete(TModel model)
           => _connection.Delete<TModel>(model);

    // CRIAÇÃO DO DELETE (6-METODO)
    public void Delete(int id)
    {
      var model = _connection.Get<TModel>(id);
      _connection.Delete<TModel>(model);
    }
  }
}