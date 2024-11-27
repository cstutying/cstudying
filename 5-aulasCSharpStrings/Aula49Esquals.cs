// EQUALS

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {

      var texto = "Este texto é um teste";
      Console.WriteLine(texto.Equals("Este texto é um teste")); // MEU TESTE COMEÇA COM "Este"? com (E Maiúsculo)
      Console.WriteLine(texto.Equals("este texto é um teste")); // MEU TESTE COMEÇA COM "este"? com (e Minusculo)
      Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase)); // MEU TESTO COMEÇA COM "este"? com (e Minusculo)
    }
  }
}

