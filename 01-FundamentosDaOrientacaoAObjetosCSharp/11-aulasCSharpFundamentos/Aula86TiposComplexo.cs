// TIPOS COMPLEXOS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var pagamento = new Pagamento();

      Console.WriteLine("Ola");
    }
  }

  // PRIVATE - ELE FICA RESTRITO AO ESCOPO DA CLASS
  //  PROTECTED - ELE É O ESCOPO DA CLASS MAIS A CLASS FILHO
  // INTERNAL -
  //  PUBLIC - E PUBLIC ELE TA DE FATO PUBLIC QUAL QUER PESSOA DE FORA PODE ALTERA AS INFORMAÇÃO DA CLASS

  public class Pagamento // SE NÃO COLOCAR NADA A CLASS E CONSIDERADA PRIVADA
  {
    // AS VARIÁVEIS QUE TEM (SE TORNAM PROPRIEDADES)
    protected DateTime Vencimento;

    // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
    private void Pagar() { }

  }
  // METODO HERANÇA
  public class PagamentoBoleto : Pagamento
  {
    void Test()
    {
      // base.Vencimento;
    }
  }
}