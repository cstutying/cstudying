// FORMATANDO MOEDAS

using System;
using System.Globalization;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      decimal valor = 10.25m;

      Console.WriteLine(
        valor.ToString(
          // TIPOS DE FORMATAÇÃO PADRÃO C, E04, F, N, G, P
          // "E04", // ELE SEMPRE CRIA AQUELE FORMATAÇÃO QUANDO NUMERO É MUITO GRANDE
          "C",// FORMATADOR NUMÉRICO COMO MOEDA
          CultureInfo.CreateSpecificCulture("pt-br") // CONVERTE PARA CULTURA BRASILEIRA
        )
      );
    }
  }
}