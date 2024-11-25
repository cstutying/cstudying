// COMPARANDO STRINGS

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.Contains("teste"));
      Console.WriteLine(texto.Contains("Teste"));
      Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
      Console.WriteLine(texto.Contains(null));

      // EXEMPLO 2
      // var texto = "Testando";
      // Console.WriteLine(texto.CompareTo("Testando"));
      // Console.WriteLine(texto.CompareTo("testando"));
    }
  }
}
