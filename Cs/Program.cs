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

    public class Pagamento // SE NÃO COLOCAR NADA A CLASS E CONSIDERADA PRIVADA
    {
        // AS VARIÁVEIS QUE TEM (SE TORNAM PROPRIEDADES)
        DateTime Vencimento;

        // AS FUNÇÕES QUE TEM (SE TORNAM MÉTODOS)
        void Pagar() { }
    }
}