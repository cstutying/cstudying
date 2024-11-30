// MATH

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      decimal valor = 10536.25m;
      Console.WriteLine(Math.Round(valor)); //ARREDONDA OS NUMERO
      Console.WriteLine(Math.Ceiling(valor)); //ARREDONDA SEMPRE PRA CIMA
      Console.WriteLine(Math.Floor(valor)); //ARREDONDA SEMPRE PRA BAIXO
    }
  }
}
