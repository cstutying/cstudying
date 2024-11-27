// CULTURE INFO

// PARA USAR O "CULTURE INFO"  PASSAR ESSE PARAMETRO (using System.Globalization;)
// SHORT TIME (HR COMPACTADA) = t 
// MENOR DATA = d
// COMBINA AS DUAS DATA = f
// COMBINA DATA E HORA NO SHORT(COMPACTADO) = g
// USA PADRÃO UNIVERSAL = U
// USA PADRÃO QUE MUITOS SISTEMA USA = r
// PADRÃO PARA QUEM USA MONGO = s
// PADRÃO PARA QUEM USA JSON = u

using System;
using System.Globalization;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      //  CULTURE INFO CONVERTE A DATA PARA HORÁRIO LOCAL
      var br = new CultureInfo("pt-BR"); // PORTUGAL
      var pt = new CultureInfo("pt-PT"); // BRASIL
      var en = new CultureInfo("en-US"); // ESTADOS UNIDO
      var de = new CultureInfo("de-DE"); // DINAMARCA
      var ENuS = new CultureInfo("pt-BR"); // ESTADOS UNIDO / BRASIL
      var atual = CultureInfo.CurrentCulture; // DATA/DIA EM TEMPO REAL ATUAL

      Console.WriteLine(DateTime.Now.ToString("D", atual)); // EXIBE  CultureInfo.CurrentCulture EM TEMPO REAL

      // Console.WriteLine(string.Format("{0:D}", DateTime.Now.ToString("d"))); // EXIBE SHORTY DAY TIME
      // Console.WriteLine(DateTime.Now.ToString("D")); // EXIBE LONG DAY TIME
      // Console.WriteLine(DateTime.Now.ToString("D", de)); // EXIBE A NACIONALIDADE DA DATA (ex: BR, DE, EUA, PT)
    }
  }
}