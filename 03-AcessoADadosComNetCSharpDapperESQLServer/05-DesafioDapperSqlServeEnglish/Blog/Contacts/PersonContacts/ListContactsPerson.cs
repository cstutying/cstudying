// SEGUNDO MÉTODO CRIADO

using Blog.Models;
using Blog.Registers.UserRegisters;
using Blog.Repositories;

namespace Blog.Contacts.PersonContacts;

public static class ListContactsPerson
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Contact List");
    Console.WriteLine("------------");

    List();
    Console.ReadKey();
    MenuContactsPerson.Loading();
  }

  private static void List()
  {
    var repository = new Repository<Contact>(Database.Connection);
    var contacts = repository.Get();
    foreach (var item in contacts)
      Console.WriteLine(
        $"[ID]:{item.Id} [Nome]:{item.Name} [Numero]:{item.Number} [Email]:{item.Email} [Data]:{item.Date} [Rede Social]:{item.Socials}");
  }
}