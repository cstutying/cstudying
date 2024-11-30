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


            Console.WriteLine("Ola");
        }
    }

    // CONSIDERADA CLASS PAI
    class Pagamento
    {
        // AS VARIÁVEIS QUE TEM SE TORNAM PROPRIEDADES
        public DateTime Vencimento;
        // AS FUNÇÕES QUE TEM SE TORNAM MÉTODOS
        public void Pagar() { }
    }

    // CONSIDERADA CLASS FILHO
    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;
    }
    // CONSIDERADA CLASS FILHO
    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero;
    }
}