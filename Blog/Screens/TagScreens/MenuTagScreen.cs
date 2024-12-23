// PRIMEIRO MÉTODO CRIADO

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Screens.TagScreens
{
  public static class MenuTagScreen
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Gestão de tags");
      Console.WriteLine("--------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar tags");
      Console.WriteLine("2 - Cadastrar tags");
      Console.WriteLine("3 - Atualizar tag");
      Console.WriteLine("4 - Excluir tag");
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
        default: Loading(); break;
      }
    }
  }
}