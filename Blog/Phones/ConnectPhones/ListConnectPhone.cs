// SEGUNDO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones
{
  public static class ListConnectPhone
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Lista Telefônica");
      Console.WriteLine("----------------");
      List();
      Console.ReadKey();
      MenuConnectPhone.Loading();
    }

    private static void List()
    {
      var repository = new Repository<Phone>(Database.Connection);
      var phones = repository.Get();
      foreach (var item in phones)
        Console.WriteLine($"{item.Id}:[Numero] {item.Number} ");
    }
  }
}