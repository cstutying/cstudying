using System.Collections.Generic;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class RoleRepository
  {
    private readonly SqlConnection _connection;

    // CRIAÇÃO DE ROLE REPOSITORY (0-METODO)
    public RoleRepository(SqlConnection connection)
    => _connection = connection;

    // CRIAÇÃO DE I ENUMERABLE (1-METODO)
    public IEnumerable<Role> Get()
    => _connection.GetAll<Role>();

    // CRIAÇÃO DE ROLE (2-METODO)
    public Role Get(int id)
    => _connection.Get<Role>(id);

    // CRIAÇÃO DO CREATE (3-METODO)
    public void Create(Role role)
    => _connection.Insert<Role>(role);

    // CRIAÇÃO DO UPDATE (4-METODO)
    public void Update(Role role)
    {
      if (role.Id != 0)
        _connection.Update<Role>(role);
    }

    // CRIAÇÃO DO DELETE (5-METODO)
    public void Delete(Role role)
    {
      if (role.Id != 0)
        _connection.Delete<Role>(role);
    }

    // CRIAÇÃO DO DELETE (6-METODO)
    public void Delete(int id)
    {
      if (id != 0)
        return;
      var role = _connection.Get<Role>(id);
      _connection.Delete<Role>(role);
    }
  }
}