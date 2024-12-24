// QUINTO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones
{
  public static class DeleteConnectPhone
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Excluir um Numero");
      Console.WriteLine("-----------");
      Console.WriteLine("Qual ID do Numero que deseja excluir?");
      var id = Console.ReadLine();

      Delete(int.Parse(id));
      Console.ReadKey();
      MenuConnectPhone.Loading();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Phone>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Numero excluído com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluir o Numero");
        Console.WriteLine(ex.Message);
      }
    }
  }
}