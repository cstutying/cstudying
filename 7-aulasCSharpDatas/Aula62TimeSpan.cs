// TIME SPAN

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      var timeSpan = new TimeSpan();
      Console.WriteLine(timeSpan);

      // COMPOSIÇÕES NO TIME SPAN
      // NANOSEGUNDOS
      var timeSpanNanosegundos = new TimeSpan(1);
      Console.WriteLine(timeSpanNanosegundos);

      // HORA MINUTO SEGUNDO
      var timeSpanHoraMinutosSegundos = new TimeSpan(5, 12, 8);
      Console.WriteLine(timeSpanHoraMinutosSegundos);

      // DIA DIA HORA MINUTO SEGUNDO
      var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

      // DIA HORA MINUTO SEGUNDO MILISSEGUNDO
      var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 8, 100);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

      // ONDE É USADO O TIME SPAN? PRA CÁLCULOS AREA ARITMÉTICA E DATAS
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
      Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

    }
  }
}