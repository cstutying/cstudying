// PADRÕES DE FORMATAÇÃO

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var data = DateTime.Now;  // DATA ATUAL DO RELÓGIO

      // var formatada = String.Format("{0:t}", data);// SHORT TIME (HR COMPACTADA) = t 
      // var formatada = String.Format("{0:d}", data); // MENOR DATA = d
      // var formatada = String.Format("{0:f}", data); // COMBINA AS DUAS DATA = f
      // var formatada = String.Format("{0:g}", data); // COMBINA DATA E HORA NO SHORT(COMPACTADO) = g
      // var formatada = String.Format("{0:u}", data); // USA PADRÃO UNIVERSAL = U

      // var formatada = String.Format("{0:r}", data);//USA PADRÃO QUE MUITOS SISTEMA USA = r
      // var formatada = String.Format("{0:s}", data);//PADRÃO PARA QUEM USA MONGO = s
      var formatada = String.Format("{0:u}", data);//PADRÃO PARA QUEM USA JSON = u

      Console.WriteLine(formatada);
    }
  }
}
