// TRATANDO ERROS

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
      //  SEMPRE VAI TRATAR OS ERRO DO MAIS ESPECIFICO PARA O MAIS GENÉRICO
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não encontrei o índex na lista");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ops, algo deu errado!");

      }

    }
  }
}