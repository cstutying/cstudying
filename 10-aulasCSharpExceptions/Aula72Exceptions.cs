// EXCEPTIONS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[3];

      for (var index = 0; index < 10; index++)
      {
        // Error: System.IndexOutOfRangeException
        // RESULTADO NA PRÓXIMA AULA 73
        Console.WriteLine(arr[index]);
      }
    }
  }
}