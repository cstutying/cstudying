// USING E DISPOSE

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var pagamento = new Pagamento())
      {
        Console.WriteLine("Processando o pagamento");
      }

      Console.WriteLine("Fim");
    }
  }

  // TODAS CLASS SÃO CONSIDERADA TIPOS COMPLEXOS
  public class Pagamento : IDisposable
  {
    public Pagamento()
    {
      Console.WriteLine("Iniciando o pagamento");
    }

    public void Dispose()
    {
      Console.WriteLine("Finalizando o pagamento");
    }
  }
}
