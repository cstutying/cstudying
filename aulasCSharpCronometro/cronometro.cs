// CRONOMETRO

using System; // PARA USAR O WriteLine DEVE USA O using system;
using System.Data;
using System.Threading;

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
      Console.WriteLine("Digite para Segundos, (S)");
      Console.WriteLine("Digite para Minutos, (M)");
      Console.WriteLine("Sair");
      Console.WriteLine("Quantos tempo deseja Contar?");

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplayer = 1;

      if (type == 'm')
        multiplayer = 60;

      if (time == 0)
        System.Environment.Exit(0);

      StartNice(time * multiplayer);
    }
    static void StartNice(int time)
    {
      Console.Clear();
      Console.WriteLine("Ler...");
      Thread.Sleep(500);
      Console.WriteLine("Definir...");
      Thread.Sleep(500);
      Console.WriteLine("Ir...");
      Thread.Sleep(1000);

      Start(time);
    }
    static void Start(int time)
    {
      int currentTime = 0;
      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(800);
      }

      Console.Clear();
      Console.WriteLine("Cronometro Finalizado...");
      Thread.Sleep(1500);
      Menu();
    }
  }
}
