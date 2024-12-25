using Blog.Models;
using Blog.Repositories;

namespace Blog.Registers.UserRegisters;

public class DeleteUsersRegister
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Exclude a user: ");
    Console.WriteLine("------------");
    Console.WriteLine("Which User ID do you want to exclude?: ");
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
      Console.WriteLine("User excluded with success!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to exclude the User");
      Console.WriteLine(ex.Message);
    }
  }
}