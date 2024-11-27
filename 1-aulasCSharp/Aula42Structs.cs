// STRUCTS
// Tipos de dado estruturado
// Apenas a estrutura, o esqueleto
// Tipo de valor
// Armazenam apenas outros tipos de dados
// Definido pela palavra STRUCT
// Composto de propriedades e métodos
// Nome sempre com LETRA Maiúscula
//      O Mesmo para propriedades e métodos
// Criado a partir de palavra NEW (sempre que quisermos criar um STRUCTS utiliza a palavra NEW)
//      Neste momento sim temos os valores

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{

  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 1
      // CRIAR UMA ESTRUTURA
      // var product = new Product();
      // product.Id = 1;
      // product.Title = "C#";
      // product.Price = 197.23f;
      // Console.WriteLine(product.Id);
      // Console.WriteLine(product.Title);
      // Console.WriteLine(product.Price);

      // EXEMPLO 2
      var product = new Product(1, "Mouse Gamer", 128.75f);
      Console.WriteLine(product.Id);
      Console.WriteLine(product.Title);
      Console.WriteLine(product.Price);
      Console.WriteLine(product.PriceInDolar(5.70f));
    }
  }
}
