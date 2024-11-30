// TRY CATCH (SÃO A BASE PARA TRATAR ERROS)

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[3];

      try
      {
        for (var index = 0; index < 10; index++)
        {
          // Error: System.IndexOutOfRangeException
          Console.WriteLine(arr[index]);
        }

      }
      //     EXCEPTION GERA UM LOG DO ERRO DA APLICAÇÃO
      catch (Exception ex)
      {
        Console.WriteLine(ex.InnerException); //GERA UM LOG DO ERRO DA APLICAÇÃO
        Console.WriteLine(ex.Message); //GERA UM LOG DO ERRO DA APLICAÇÃO
        Console.WriteLine("Ops, algo deu errado!");
      }

    }
  }
}