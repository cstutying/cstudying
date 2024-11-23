// CALCULADORA

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("5 - Multiplicação");

      Console.WriteLine("-------------------");
      Console.WriteLine("Selecione uma opção");
      short result = short.Parse(Console.ReadLine());
    }

    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = firstValue + secondValue;
      // Console.WriteLine("O resultado da soma é: " + resultado); // (OPÇÃO 1)
      Console.WriteLine($"O resultado da soma é: {resultado}"); // (OPÇÃO 2)
      // Console.WriteLine($"O resultado da soma é: {firstValue + secondValue}"); // (OPÇÃO 3)
      // Console.WriteLine("O resultado da soma é: " + (firstValue + secondValue)); // (OPÇÃO 4)
      Console.ReadKey();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = firstValue - secondValue;
      Console.WriteLine($"O resultado da subtração é {resultado}");
      Console.ReadKey();
    }

    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor:");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = firstValue / secondValue;
      Console.WriteLine($"O resultado da divisão é{resultado}");
      Console.ReadKey();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = firstValue * secondValue;

      Console.WriteLine($"Resultado da Multiplicação: {resultado}");
      Console.ReadKey();
    }
  }
}
