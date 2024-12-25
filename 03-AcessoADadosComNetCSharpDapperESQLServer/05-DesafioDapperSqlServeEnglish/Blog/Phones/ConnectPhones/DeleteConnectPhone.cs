using Blog.Models;
using Blog.Registers.UserRegisters;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones;

public static class DeleteConnectPhone
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Exclude a Number");
    Console.WriteLine("------------");
    Console.WriteLine("What ID or Number do you want to exclude?");
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
      Console.WriteLine("Number successfully excluded!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to exclude the number");
      Console.WriteLine(ex.Message);
    }
  }
}