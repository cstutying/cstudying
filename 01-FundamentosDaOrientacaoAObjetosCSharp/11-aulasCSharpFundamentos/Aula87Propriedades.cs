// PROPRIEDADES

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamento = new Pagamento();
      pagamento.DataPagamento = DateTime.Now;

      Console.WriteLine("Ola");
    }
  }
  // TODAS CLASS SÃO CONSIDERADA TIPOS COMPLEXOS
  public class Pagamento
  {
    // PROPG (POR ENQUANTO NÃO IREMOS USAR)
    // public DateTime Teste { get; private set; }

    public string NumeroBoleto;

    // PROP
    public DateTime Vencimento
    {
      get
      {
        return Vencimento;
      }
      set { }
    } // PODE CRIAR UMA PROPRIEDADE MAIS CURTA COM {GET; SET;}

    private DateTime _dataPagamento;// É COMUM AS PESSOAS USAREM _ EM VARIÁVEIS PRIVATE NA FRENTE

    // PROPFULL
    public DateTime DataPagamento
    {
      get
      {
        Console.WriteLine("Lendo o valor");
        return _dataPagamento.AddDays(1);
      }
      set
      {
        Console.WriteLine("Atribuindo o valor");
        _dataPagamento = value;
      }
    }

    // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
    void Pagar() { }
  }
  public class Address
  {
    string ZipCode;
  }
}