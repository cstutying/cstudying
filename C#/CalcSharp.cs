using System;

namespace Calculadora
{
  class CalcSharp
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Calculadora");
      Console.WriteLine("-----------");

      while (true)
      {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
          case 1:
            Soma();
            break;
          case 2:
            Subtracao();
            break;
          case 3:
            Multiplicacao();
            break;
          case 4:
            Divisao();
            break;
          case 5:
            Environment.Exit(0);
            break;
          default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
        }
      }
    }

    static void Soma()
    {
      Console.Write("Digite o primeiro número: ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Digite o segundo número: ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      double resultado = num1 + num2;

      Console.WriteLine($"Resultado: {resultado}");
    }

    static void Subtracao()
    {
      Console.Write("Digite o primeiro número: ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Digite o segundo número: ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      double resultado = num1 - num2;

      Console.WriteLine($"Resultado: {resultado}");
    }

    static void Multiplicacao()
    {
      Console.Write("Digite o primeiro número: ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Digite o segundo número: ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      double resultado = num1 * num2;

      Console.WriteLine($"Resultado: {resultado}");
    }

    static void Divisao()
    {
      Console.Write("Digite o primeiro número: ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Digite o segundo número: ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      if (num2 != 0)
      {
        double resultado = num1 / num2;
        Console.WriteLine($"Resultado: {resultado}");
      }
      else
      {
        Console.WriteLine("Erro: divisão por zero.");
      }
    }
  }
}
