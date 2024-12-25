// QUINTO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Registers.UserRegisters
{
  public static class DeleteUsersRegister
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Excluir um usuário");
      Console.WriteLine("---------------");
      Console.WriteLine("Qual id do Usuário deseja excluir?: ");
      var id = Console.ReadLine();

      Delete(int.Parse(id));
      Console.ReadKey();
      MenuUsersRegister.Loading();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Usuário excluído com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluír a Usuário");
        Console.WriteLine(ex.Message);
      }
    }
  }
}