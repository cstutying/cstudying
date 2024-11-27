// OBTENDO OS VALORES DE DATA 

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // var data = new DateTime(2024, 11, 26, 13, 23, 14); // DATA: ANO/MES/SEMANA/DIA/MINUTO/SEGUNDO (MANUAL)
      var data = DateTime.Now; // DATA ATUAL DO RELÓGIO
      Console.WriteLine(data);
      Console.WriteLine(data.Year); // ANO
      Console.WriteLine(data.Month); // MES
      Console.WriteLine(data.Day); // DIA
      Console.WriteLine(data.Hour); // HORA
      Console.WriteLine(data.Minute); // MINUTO
      Console.WriteLine(data.Second); // SEGUNDO

      // Console.WriteLine(data.DayOfYear); // QUAL DIA DO ANO
      // Console.WriteLine((int)data.DayOfWeek); // QUAL  DIA DA SEMANA CONVERTIDO EM NUMERO
      Console.WriteLine(data.DayOfWeek); // QUAL DIA DA SEMANA CONVERTIDO EM PALAVRA

    }
  }
}
