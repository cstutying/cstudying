// INDICES

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      // SEMPRE QUE VER O INDICES (INDEX) ELE TA SE REFERENDO A POSIÇÃO
      Console.WriteLine(texto.IndexOf("é"));
      Console.WriteLine(texto.LastIndexOf("s")); // LEMBRE QUE ELE SEMPRE VAI PEDIR UM OBJETO DO MESMO TIPO
    }
  }
}

