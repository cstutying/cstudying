// PRIMEIRO MÉTODO CRIADO

namespace Blog.Phones.ConnectPhones;

public static class MenuConnectPhone
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Connect Phone");
    Console.WriteLine("------------");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine();
    Console.WriteLine("1 - List Phones");
    Console.WriteLine("2 - Register phone");
    Console.WriteLine("3 - Update phone");
    Console.WriteLine("4 - Exclude phone");
    Console.WriteLine("5 - Exit");
    Console.WriteLine();

    var option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
      case 1:
        ListConnectPhone.Loading();
        break;
      case 2:
        CreateConnectPhone.Loading();
        break;
      case 3:
        UpdateConnectPhone.Loading();
        break;
      case 4:
        DeleteConnectPhone.Loading();
        break;
      case 5:
        Environment.Exit(0);
        break;
      default: Loading(); break;
    }
  }
}