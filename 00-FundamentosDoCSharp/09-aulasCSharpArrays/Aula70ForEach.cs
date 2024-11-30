// FOR EACH

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var empregados = new Funcionario[5];
      empregados[0] = new Funcionario() { Id = 2579, Nome = "Douglas" };

      // FOREACH PARA CADA ITEM DO MEU ARRAY (PRIORIZAR USAR FOREACH)
      foreach (var funcionario in empregados)
      {
        Console.WriteLine(funcionario.Id);
        Console.WriteLine(funcionario.Nome);
      }
    }
  }

  public struct Funcionario
  {
    public int Id { get; set; }
    public string Nome { get; set; }
  }
}
