// QUINTO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Contacts.PersonContacts;

public static class DeleteContactsPerson
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Exclude a Contact");
    Console.WriteLine("--------------");
    Console.WriteLine("Qual Contact ID you want to exclude");
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
      Console.WriteLine("Contact excluded with success!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to exclude or Contact");
      Console.WriteLine(ex.Message);
    }
  }
}