// ALTERANDO VALORES

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var primeiro = new int[4];
      var segundo = new int[4];

      // LEMBRANDO QUE ELES SÃO OBJETOS DE REFERENCIA E NAO OBJETOS DE VALOR
      segundo[0] = primeiro[0];

      primeiro[0] = 23;
      Console.WriteLine(segundo[0]);
    }
  }

  public struct Funcionario
  {
    public int Id { get; set; }
    public string Nome { get; set; }
  }
}