// PRIMEIRO MÉTODO CRIADO

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Registers.UserRegisters
{
  public static class MenuUsersRegister
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Gestão de Usuários");
      Console.WriteLine("--------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar Usuários");
      Console.WriteLine("2 - Cadastrar Usuários");
      Console.WriteLine("3 - Atualizar Usuários");
      Console.WriteLine("4 - Excluir Usuários");
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
        default: Loading(); break;
      }
    }
  }
}