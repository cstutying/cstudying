// 

using System;
using System.Globalization;

namespace Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m; // MELHOR MODO PARA TRABALHA E O DECIMAL

            // MELHOR MODO PARA FORMATA UM VALOR
            valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"));

            Console.WriteLine(Math.Round(valor)); //ARREDONDA OS NUMERO
            Console.WriteLine(Math.Ceiling(valor)); //ARREDONDA SEMPRE PRA CIMA
            Console.WriteLine(Math.Floor(valor)); //ARREDONDA SEMPRE PRA BAIXO
        }
    }
}
