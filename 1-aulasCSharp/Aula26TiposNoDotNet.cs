// CONVERTENDO TIPOS NO DOT NET

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int inteiro = 100;
      float real = 25.5f;

      // real = inteiro; // O VALOR PASSOU A SER 100.0F
      // inteiro = (int)real; // O VALOR PASSOU A SER 25 (CONVERSÃO EXPLICITA)
      // string valorReal = real.ToString();
      // inteiro = int.Parse("255");
      // inteiro = Convert.ToInt32(real);

      // Console.WriteLine(valorReal);
      Console.WriteLine(inteiro);
      Console.WriteLine(Convert.ToBoolean("true"));
    }
  }
}
