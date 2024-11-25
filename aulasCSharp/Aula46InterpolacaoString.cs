// INTERPOLAÇÃO STRING

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // var price = 10.2 + 9; // SOMA EX: 10.2 + 9 = 19.2
      // var price = true; // BOOLEAN
      var price = 10.2;
      // var texto = "O preço do produto " + price + " apenas na promoção"; // PRIMEIRA FORMA DE FAZER UMA INTERPOLAÇÃO
      // var texto = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true); 
      //                    Format(FORMATA UMA STRING)
      var texto = $"O preço do produto \n é{price} apenas na promoção"; // ESSE ESTILO DE FORMATAÇÃO É O MELHOR
      Console.WriteLine(texto);

    }
  }
}
