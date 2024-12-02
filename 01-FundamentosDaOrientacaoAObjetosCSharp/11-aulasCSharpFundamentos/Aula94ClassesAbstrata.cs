// CLASSES ABSTRATA
// CONTRATO DEFINE OQUE TEM Q SER FEITO
// ABSTRAÇÃO TEM UMA IMPLEMENTAÇÃO BASE DO QUE DEVE SER FEITO

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ola");
      // var pagamento = new Pagamento();
    }
  }

  // OQUE SIGNIFICA ABSTRACT: ELA NÃO PODE SER ESTANCIADA 
  public abstract class Pagamento : IPagamento
  {
    public DateTime Vencimento { get; set; }

    public virtual void Pagar(double valor)
    {
      // EXECUTAR ALGO (EX: UMA VALIDAÇÃO)
    }
  }

  public class PagamentoCartaoCredito : Pagamento
  {
    public override void Pagar(double valor)
    {
      base.Pagar(valor);
    }
  }

  public class PagamentoApplePay : Pagamento
  {
    public override void Pagar(double valor)
    {
      base.Pagar(valor);
    }
  }

  public class PagamentoBoleto : Pagamento
  {
    public override void Pagar(double valor)
    {
      base.Pagar(valor);
    }
  }

  // INTERFACE NÃO CONTEM IMPLEMENTAÇÃO
  public interface IPagamento
  {
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
  }
}