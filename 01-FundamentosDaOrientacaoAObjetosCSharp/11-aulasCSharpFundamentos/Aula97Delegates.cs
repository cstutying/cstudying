// DELEGATES: DIRECIONAR UMA TAREFA

using System;
using System.Security.Cryptography.X509Certificates;

namespace Cs
{
  class Program
  {
    static void RealizarPagamento(double valor)
    {
      Console.WriteLine($"Pago o valor de {valor}");
    }

    static void Main(string[] args)
    {
      var pagar = new Pagamento.Pagar(RealizarPagamento);
      pagar(25);
    }
  }

  public class Pagamento
  {
    public delegate void Pagar(double valor);
  }
}
