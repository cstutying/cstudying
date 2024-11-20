using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int? idade = 0; // INICIOU COM ZERO
      // byte? t = 127;
      Console.WriteLine(idade); // VAI IMPRIMIR ZERO
      idade = null; // INICIOU COM NULL
      Console.WriteLine(idade); // VAI IMPRIMIR NADA 
      idade = 25; // VOLTOU COM 25
      Console.WriteLine(idade); // VAI IMPRIMIR 25 NA TELA
    }
  }
}