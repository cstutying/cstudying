 // Console.WriteLine(DateTime.Now); // DATA/HORÁRIO DO SERVIDOR
      // Console.WriteLine(utcDate); // DATA/HORÁRIO GLOBAL
      // Console.WriteLine(utcDate.ToLocalTime()); // DATA (ATUAL)/HORÁRIO GLOBAL RECOMENDADO PARA QUEM USA APLICAÇÃO GLOBALMENTE

      // // OQUE FAZER SE MINHA MAQUINA/HORA TA NO BRASIL E MEU USUÁRIO TA NA AUSTRALIA USAR
      // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
      // Console.WriteLine(timezoneAustralia);

      // // PEGA DATA/HORÁRIO DA AUSTRALIA (EXEMPLO)
      // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
      // Console.WriteLine(horaAustralia);