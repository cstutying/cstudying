// POLIMORFISMO

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamentoBoleto = new PagamentoBoleto();
      pagamentoBoleto.Pagar();
      pagamentoBoleto.Vencimento = DateTime.Now;
      pagamentoBoleto.NumeroBoleto = "123";

      var pagamento = new Pagamento();
      pagamento.ToString();


      Console.WriteLine("Ola");
    }
  }

  // CONSIDERADA CLASS PAI
  class Pagamento
  {
    // AS VARIÁVEIS QUE TEM (SE TORNAM PROPRIEDADES)
    public DateTime Vencimento;
    // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
    // 1-  VIRTUAL NO PAI
    public virtual void Pagar() { }

    public override string ToString()
    {
      return Vencimento.ToString("dd/MM/yyyy");
    }
  }

  // CONSIDERADA CLASS FILHO
  class PagamentoBoleto : Pagamento
  {
    public string NumeroBoleto;

    // 2-  OVERRIDE NO FILHO
    public override void Pagar()
    {
      // 3- ESTOU SOBRESCREVENDO UMA FORMA NOVA DE PAGAR
      // REGRA DO BOLETO
    }
  }
  // CONSIDERADA CLASS FILHO
  class PagamentoCartaoCredito : Pagamento
  {
    public string Numero;

    public override void Pagar()
    {
      // REGRA DO CARTÃO DE CRÉDITO
    }
  }
}