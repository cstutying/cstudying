// ENUMS  (INTEIRO QUE FORNECE UMA VISUALIZAÇÃO MELHOR PARA NOSSO CÓDIGO)
// Usando para fornecer uma visão melhor para o nosso código
// Substituem o uso de inteiros
// Usados em listas curas
// Usados em dados fixos
//    HARD CODED
// Sempre com LETRA MAIÚSCULA
//    Começa com a letra E

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // Product mouse = new Product(1, "Mouse Gamer", 299.97); // TANTO FAZ COLOCAR NOME DO TIPO (Product) QUANTO COLOCAR NOME DO VAR
      var mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);  // TANTO FAZ COLOCAR NOME DO VAR QUANTO COLOCAR NOME DO TIPO
      var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);

      mouse.Id = 55;

      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
      Console.WriteLine(mouse.Type);
      Console.WriteLine((int)mouse.Type);
    }
  }
  struct Product
  {
    public Product(int id, string name, double price, EProductType type)
    {
      Id = id;
      Name = name;
      Price = price;
      Type = type;
    }

    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }
  }
  enum EProductType
  {
    Product = 1,
    Service = 2
  }
}
