// QUARTO MÉTODO CRIADO

using System.Linq.Expressions;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones;

public class UpdateConnectPhone
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Updating Telephone Record");
    Console.WriteLine("---------");

    Console.WriteLine("Enter your ID: ");
    var id = Console.ReadLine();

    Console.WriteLine("Enter the new number you want to update:");
    var number = Console.ReadLine();

    Update(new Phone
    {
      Id = int.Parse(id),
      Number = number
    });
    Console.ReadKey();
    MenuConnectPhone.Loading();
  }

  public static void Update(Phone phone)
  {
    try
    {
      var repository = new Repository<Phone>(Database.Connection);
      repository.Update(phone);
      Console.WriteLine("Telephone updated with success!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to save the phone");
      Console.WriteLine(ex.Message);
    }
  }
}