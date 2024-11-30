// STRUCTS PRÁTICA
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
      // Product mouse = new Product(1, "Mouse Gamer", 299.97); // TANTO FAZ COLOCAR NOME DO TIPO (Product) QUANTO COLOCAR NOME DO VAR
      var mouse = new Product(1, "Mouse Gamer", 299.97);  // TANTO FAZ COLOCAR NOME DO VAR QUANTO COLOCAR NOME DO TIPO

      mouse.Id = 55;

      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
    }
  }
  struct Product
  {
    public Product(int id, string name, double price)
    {
      Id = id;
      Name = name;
      Price = price;
    }

    public int Id;
    public string Name;
    public double Price;

    public double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }
  }
}
