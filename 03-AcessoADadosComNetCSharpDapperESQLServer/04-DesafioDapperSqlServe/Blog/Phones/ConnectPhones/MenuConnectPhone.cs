// PRIMEIRO MÉTODO CRIADO

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Phones.ConnectPhones
{
  public static class MenuConnectPhone
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Menu Telefônico");
      Console.WriteLine("--------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Lista telefonica");
      Console.WriteLine("2 - Cadastrar Numero");
      Console.WriteLine("3 - Atualizar Numero");
      Console.WriteLine("4 - Excluir Numero");
      Console.WriteLine("5 - Sair");
      Console.WriteLine();
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
}