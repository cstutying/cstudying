// SEGUNDO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Registers.UserRegisters;

public static class ListUsersRegister
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Listar de Usuários");
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
      Console.WriteLine($"{item.Id} - {item.Name} [{item.Email}]");
    }
  }
}