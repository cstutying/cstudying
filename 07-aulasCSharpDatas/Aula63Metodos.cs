// MÉTODOS

using System;
using System.Xml;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // QUANTOS DIAS TEM UM MES             
      Console.WriteLine(DateTime.DaysInMonth(2024, 11));//(ANO, MES)

      Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek)); // SE É FIM DE SEMANA OU NÃO

      Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // IMPORTANTE PRA QUANDO USAR HORAS (HORÁRIO DE VERÃO)
    }

    // SE É FIM DE SEMANA OU NÃO
    static bool IsWeekend(DayOfWeek today)
    {
      return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
  }
}