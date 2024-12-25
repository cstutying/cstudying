// PRIMEIRO MÉTODO CRIADO

namespace Blog.Registers.UserRegisters;

public static class MenuUsersRegister
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("User Management");
    Console.WriteLine("--------------");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine();
    Console.WriteLine("1 - List Users");
    Console.WriteLine("2 - Register Users");
    Console.WriteLine("3 - Update Users");
    Console.WriteLine("4 - Exclude Users");
    Console.WriteLine("5 - Exit");
    Console.WriteLine();
    Console.WriteLine();
    var option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
      case 1:
        ListUsersRegister.Loading();
        break;
      case 2:
        CreateUsersRegister.Loading();
        break;
      case 3:
        UpdateUsersRegister.Loading();
        break;
      case 4:
        DeleteUsersRegister.Loading();
        break;
      case 5:
        Environment.Exit(0);
        break;
      default: Loading(); break;
    }
  }
}