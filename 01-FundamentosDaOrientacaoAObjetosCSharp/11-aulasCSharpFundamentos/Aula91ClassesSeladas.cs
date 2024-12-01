// CLASSES SELADAS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ola");
    }
  }
  public sealed class Pagamento
  {
    public static DateTime Vencimento { get; set; }

  }
}
