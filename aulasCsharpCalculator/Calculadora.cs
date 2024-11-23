// CALCULADORA
// FUNÇÕES SEMPRE VAI COMEÇAR COM MAIÚSCULO
// PARÂMETROS SEMPRE VAI COMEÇAR COM MINUSCULO
// NOMES VARIÁVEIS SEMPRE VAI COMEÇAR COM MINUSCULO

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
   Console.WriteLine("4 - Multiplicação");
   Console.WriteLine("5 - Sair");

   Console.WriteLine("-------------------");
   Console.WriteLine("Selecione uma opção");
   short result = short.Parse(Console.ReadLine());

   switch (result)
   {
    case 1: Soma(); break;
    case 2: Subtracao(); break;
    case 3: Divisao(); break;
    case 4: Multiplicacao(); break;
    case 5: System.Environment.Exit(0); break;
    default: Menu(); break;

   }
  }

  static void Soma()
  {
   Console.Clear();

   Console.WriteLine("Primeiro valor da Soma:");
   float firstValue = float.Parse(Console.ReadLine());

   Console.WriteLine("Segundo Valor da Soma:");
   float secondValue = float.Parse(Console.ReadLine());

   Console.WriteLine("");

   float resultado = firstValue + secondValue;
   // Console.WriteLine("O resultado da soma é: " + resultado); /* (OPÇÃO 1) */
   Console.WriteLine($"O resultado da soma é: {resultado}"); /* (OPÇÃO 2) */
   // Console.WriteLine($"O resultado da soma é: {firstValue + secondValue}"); // (OPÇÃO 3)
   // Console.WriteLine("O resultado da soma é: " + (firstValue + secondValue)); // (OPÇÃO 4)
   Console.ReadKey();
   Menu();
  }

  static void Subtracao()
  {
   Console.Clear();

   Console.WriteLine("Primeiro valor da Subtração:");
   float firstValue = float.Parse(Console.ReadLine());

   Console.WriteLine("Segundo Valor da Subtração:");
   float secondValue = float.Parse(Console.ReadLine());

   Console.WriteLine("");

   float resultado = firstValue - secondValue;
   Console.WriteLine($"O resultado da subtração é {resultado}");
   Console.ReadKey();
   Menu();
  }

  static void Divisao()
  {
   Console.Clear();
   Console.WriteLine("Primeiro valor da Divisão:");
   float firstValue = float.Parse(Console.ReadLine());

   Console.WriteLine("Segundo valor da Divisão:");
   float secondValue = float.Parse(Console.ReadLine());

   Console.WriteLine("");

   float resultado = firstValue / secondValue;
   Console.WriteLine($"O resultado da divisão é {resultado}");
   Console.ReadKey();
   Menu();
  }

  static void Multiplicacao()
  {
   Console.Clear();

   Console.WriteLine("Primeiro valor da Multiplicação:");
   float firstValue = float.Parse(Console.ReadLine());

   Console.WriteLine("Segundo valor da Multiplicacao");
   float secondValue = float.Parse(Console.ReadLine());

   Console.WriteLine("");

   float resultado = firstValue * secondValue;

   Console.WriteLine($"Resultado da Multiplicação: {resultado}");
   Console.ReadKey();
   Menu();
  }
 }
}
