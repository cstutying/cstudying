// STARTS WITH E ENDS WITH

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.StartsWith("Este")); // MEU TESTE COMEÇA COM "Este"? com (E Maiúsculo)
      Console.WriteLine(texto.StartsWith("teste"));// MEU TESTE COMEÇA COM "teste"? com (t Minusculo)
      Console.WriteLine(texto.StartsWith("teste", StringComparison.OrdinalIgnoreCase));// MEU TESTO COMEÇA COM "teste"? com (t Minusculo)
      Console.WriteLine(texto.StartsWith("texto")); // MEU TESTE COMEÇA COM "texto"? com (e Minusculo)

      Console.WriteLine(texto.EndsWith("teste")); // MEU TESTE COMEÇA COM "teste"? com (t Minusculo)
      Console.WriteLine(texto.EndsWith("Teste")); // MEU TESTE COMEÇA COM "Teste"? com (T Maiúsculo)
      Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));// MEU TESTO COMEÇA COM "Teste"? com (T Maiúsculo)
      Console.WriteLine(texto.EndsWith("next")); // MEU TESTE COMEÇA COM "next"? com (n Minusculo)
    }
  }
}

