using Blog.Models;
using Blog.Repositories;

namespace Blog.Contacts.PersonsContacts
{
  public static class DeleteContactsPerson
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Excluir um Contato");
      Console.WriteLine("--------------");
      Console.WriteLine("Qual ID do Contato deseja excluir");
      var id = Console.ReadLine();

      Delete(int.Parse(id));
      Console.ReadKey();
      MenuContactsPerson.Loading();
    }

    public static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Contact>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Contato excluído com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluir o Contato");
        Console.WriteLine(ex.Message);
      }
    }
  }
}