// SEGUNDO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Registers.UserRegisters;

public static class ListUsersRegister
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("List of Users");
    Console.WriteLine();

    List();

    Console.ReadKey();
    MenuUsersRegister.Loading();
  }

  private static void List()
  {
    var repository = new Repository<User>(Database.Connection);
    var users = repository.Get();
    foreach (var item in users)
    {
      Console.WriteLine(
        $"[ID]:{item.Id} [Nome]:{item.Name} [Email]:{item.Email} [Slug]:{item.Slug}");
    }
  }
}