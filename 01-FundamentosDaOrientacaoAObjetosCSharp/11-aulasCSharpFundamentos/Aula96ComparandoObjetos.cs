// UPCAST E DOWNCAST

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var pessoaA = new Pessoa(1, "Douglas M");
      var pessoaB = new Pessoa(1, "Douglas M");

      Console.WriteLine(pessoaA.Equals(pessoaB));

    }
  }
  public class Pessoa : IEquatable<Pessoa>
  {
    public Pessoa(int id, String nome)
    {
      Id = id;
      Nome = nome;
    }
    public int Id { get; set; }

    public string Nome { get; set; }

    public bool Equals(Pessoa person)
    {
      return Id == person.Id;
    }
  }
}
