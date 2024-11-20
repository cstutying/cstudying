using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int? idade = 0;
      // byte? t = 127;
      Console.WriteLine(idade);
      idade = null;
      Console.WriteLine(idade);
      idade = 25;
      Console.WriteLine(idade);
    }
  }
}