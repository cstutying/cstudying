// ABSTRAÇÃO

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

  class Pagamento
  {
    // AS VARIÁVEIS QUE TEM (SE TORNAM PROPRIEDADES)
    DateTime Vencimento;

    // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
    void Pagar()
    {
      ConsultarSaldoDoCartao("1231251");
    }

    private void ConsultarSaldoDoCartao(string numero)
    {

    }
  }
}