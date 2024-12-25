// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones;

public static class CreateConnectPhone
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Registry Number");
    Console.WriteLine("----------");

    Console.WriteLine("Enter the number you wish to register:");
    var number = Console.ReadLine();

    while (true)
    {
      if (string.IsNullOrEmpty(number) || !number.All(char.IsDigit))
      {
        Console.WriteLine("Please enter a valid number containing only Numbers.");
      }
      else
      {
        break;
      }
    }

    Create(new Phone
    {
      Number = number,
    });
    Console.ReadKey();
    MenuConnectPhone.Loading();
  }

  public static void Create(Phone phone)
  {
    try
    {
      var repository = new Repository<Phone>(Database.Connection);
      repository.Create(phone);
      Console.WriteLine("Registered successfully!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to save the Phone");
      Console.WriteLine(ex.Message);
    }
  }
}