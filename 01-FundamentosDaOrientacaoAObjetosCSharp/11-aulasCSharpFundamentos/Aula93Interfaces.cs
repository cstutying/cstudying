// INTERFACES
// A INTERFACE É UM CONTRATO (É UMA DEFINIÇÃO)
// IMPLEMENTAÇÃO É UMA CLASSE QUE FAZ TUDO QUE UM CONTRATO PEDI

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ola");
    }
  }

  public class Pagamento : IPagamento
  {
    public Pagamento(DateTime vencimento)
    {
      this.Vencimento = vencimento;

    }
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor)
    {

    }
  }

  public class PagamentoCartaoCredito : IPagamento
  {
    public DateTime Vencimento { get; set; }

    public void Pagar(double valor)
    {
      throw new NotImplementedException();
    }
  }

  // INTERFACE NÃO CONTEM IMPLEMENTAÇÃO
  public interface IPagamento
  {
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
  }
}
