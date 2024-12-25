// PRIMEIRO MÉTODO CRIADO

namespace Blog.Screens.TagScreens;

public static class MenuTagScreen
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Tag management");
    Console.WriteLine("--------------");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine();
    Console.WriteLine("1 - List tags");
    Console.WriteLine("2 -Cadastrar tags");
    Console.WriteLine("3 - Update tag");
    Console.WriteLine("4 - Exclude tag");
    Console.WriteLine("5 - Exit");

    Console.WriteLine();
    Console.WriteLine();

    var option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
      case 1:
        ListTagScreen.Loading();
        break;
      case 2:
        CreateTagScreen.Loading();
        break;
      case 3:
        UpdateTagScreen.Loading();
        break;
      case 4:
        DeleteTagScreen.Loading();
        break;
      case 5:
        Environment.Exit(0);
        break;
      default: Loading(); break;
    }
  }
}