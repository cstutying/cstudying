// TIME ZONE

using System;

namespace Cs
{
  class Program
  {

    static void Main(string[] args)
    {
      Console.Clear();

      // var utcDate = DateTime.UtcNow;

      var utcDate = DateTime.UtcNow; // HORÁRIO GLOBAL RECOMENDADO PARA QUEM USA APLICAÇÃO GLOBALMENTE

      // EXEMPLO 1
      // Console.WriteLine(DateTime.Now); // DATA/HORÁRIO DO SERVIDOR
      // Console.WriteLine(utcDate); // DATA/HORÁRIO GLOBAL
      // Console.WriteLine(utcDate.ToLocalTime()); // DATA (ATUAL)/HORÁRIO GLOBAL RECOMENDADO PARA QUEM USA APLICAÇÃO GLOBALMENTE

      // // OQUE FAZER SE MINHA MAQUINA/HORA TA NO BRASIL E MEU USUÁRIO TA NA AUSTRALIA USAR
      // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      // Console.WriteLine(timezoneAustralia);

      // // PEGA DATA/HORÁRIO DA AUSTRALIA (EXEMPLO)
      // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
      // Console.WriteLine(horaAustralia);

      // EXEMPLO 2
      // LISTA TODOS OS TIME ZONE / DATA (MUNDIAL)
      var timezones = TimeZoneInfo.GetSystemTimeZones();
      // FOREACH ELE INTERAGE EM CADA ITEM
      foreach (var timezone in timezones)
      {
        Console.WriteLine(timezone.Id);
        Console.WriteLine(timezone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
        Console.WriteLine("---------------");

      }

    }
  }
}
