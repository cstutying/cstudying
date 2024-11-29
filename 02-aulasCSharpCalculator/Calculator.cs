// CALCULATOR
// FUNCTIONS WILL ALWAYS START WITH UPPERCASE
// PARAMETERS WILL ALWAYS START WITH LOWERCASE
// VARIABLE NAMES WILL ALWAYS START WITH LOWERCASE

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Calculator
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

      Console.WriteLine("What do you want to do?");
      Console.WriteLine("1 - Sum");
      Console.WriteLine("2 - Subtraction");
      Console.WriteLine("3 - Division");
      Console.WriteLine("4 - Multiplication");
      Console.WriteLine("5 - Exit");

      Console.WriteLine("------------------");
      Console.WriteLine("Select on option");
      short result = short.Parse(Console.ReadLine());


      switch (result)
      {
        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Division(); break;
        case 4: Multiplication(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }

    static void Sum()
    {
      Console.WriteLine("Number One Sum:");
      float numberOne = float.Parse(Console.ReadLine());

      Console.WriteLine("Number Two Sum:");
      float numberTwo = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float result = numberOne + numberTwo;

      Console.WriteLine($"The result is: {result}");
      Console.ReadKey();
      Menu();

    }

    static void Subtraction()
    {
      Console.Clear();

      Console.WriteLine("Number One Subtraction:");
      float numberOne = float.Parse(Console.ReadLine());

      Console.WriteLine("Number Two Subtraction:");
      float numberTwo = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float result = numberOne - numberTwo;
      Console.WriteLine($"The result is: {result}");
      Console.ReadLine();
      Menu();
    }

    static void Division()
    {
      Console.Clear();
      Console.WriteLine("Number One Division:");
      float numberOne = float.Parse(Console.ReadLine());

      Console.WriteLine("Number Two Division:");
      float numberTwo = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float result = numberOne / numberTwo;
      Console.WriteLine($"The result is: {result}");
      Console.ReadLine();
      Menu();
    }

    static void Multiplication()
    {
      Console.Clear();

      Console.WriteLine("Number One Multiplication:");
      float numberOne = float.Parse(Console.ReadLine());

      Console.WriteLine("Number Two Multiplication:");
      float numberTwo = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float result = numberOne * numberTwo;
      Console.WriteLine($"The result is: {result}");
      Console.ReadLine();
      Menu();
    }
  }
}
