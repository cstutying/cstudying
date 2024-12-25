// SEGUNDO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones;

public class ListConnectPhone
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("List of Phones");
    Console.WriteLine("-----------");
    List();
    Console.ReadKey();
    MenuConnectPhone.Loading();
  }

  public static void List()
  {
    var repository = new Repository<Phone>(Database.Connection);
    var phones = repository.Get();
    foreach (var item in phones)
      Console.WriteLine($"{item.Id}:[Numero] {item.Number} ");
  }
}