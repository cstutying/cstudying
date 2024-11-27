// PADRÕES DE FORMATAÇÃO

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      var data = DateTime.Now;
      // EVITAR FAZER COM ESSE FORMATO
      var dia = data.Day + 1;

      // SEMPRE QUE QUISER ACRESCENTAR ALGO A SUA DATA VAI USAR(RECOMENDADO)
      Console.WriteLine(data);
      Console.WriteLine(data.AddYears(1));
      Console.WriteLine(data.AddMonths(1));
      Console.WriteLine(data.AddDays(12));
      Console.WriteLine(data.AddHours(1));
      Console.WriteLine(data.AddMilliseconds(1));

    }
  }
}