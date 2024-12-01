// MÉTODOS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamento = new Pagamento(DateTime.Now);
      // var pagamento = new PagamentoCartao();
      pagamento.Pagar("122345");

    }
  }
  // TODAS CLASS SÃO CONSIDERADA TIPOS COMPLEXOS
  public class Pagamento
  {
    public DateTime dataPagamento { get; set; }

    // MÉTODO CONSTRUTOR
    public Pagamento(DateTime vencimento)
    {
      Console.WriteLine("Iniciando o Pagamento");
      dataPagamento = DateTime.Now;
    }

    // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
    public virtual void Pagar(string numero) // SOBRE ESCRITA DE MÉTODO
    {
      Console.WriteLine("Pagar");
    }

    // SOBRE CARGA DE MÉTODO
    // public void Pagar(string numero, DateTime vencimento) { }
    // public void Pagar(string numero, DateTime vencimento, bool pagarAposVencimento = false) { }
  }

  public class PagamentoCartao : Pagamento
  {
    public PagamentoCartao(DateTime vencimento)
    : base(vencimento)
    {

    }

    // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
    public override void Pagar(string numero)
    {
      base.Pagar(numero);
      Console.WriteLine("Pagar Cartao");
    }
  }

  public class Address
  {
    string ZipCode;
  }
}