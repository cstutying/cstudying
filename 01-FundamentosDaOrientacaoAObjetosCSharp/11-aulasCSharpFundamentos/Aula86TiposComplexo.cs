// MODIFICADORES DE ACESSO

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
  // TODAS CLASS SÃO CONSIDERADA TIPOS COMPLEXOS
  public class Pagamento
  {
    // AS VARIÁVEIS QUE TEM (SE TORNAM PROPRIEDADES)
    DateTime Vencimento;

    Address BillingAddress;

    // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
    void Pagar() { }
  }
  public class Address
  {
    string ZipCode;
  }
}