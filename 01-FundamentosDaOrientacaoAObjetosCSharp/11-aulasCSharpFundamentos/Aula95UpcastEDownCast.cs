// UPCAST E DOWNCAST  / UPCAST PRA CIMA  /  DOWNCAST PRA BAIXO


using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ola");
      var pessoa = new Pessoa();
      var pessoaFisica = new PessoaFisica();
      var pessoaJuridica = new PessoaJuridica();

      pessoaFisica = (PessoaFisica)pessoa;
    }
  }

  public class Pessoa
  {
    public String Nome { get; set; }
  }

  public class PessoaFisica : Pessoa
  {
    public string CPF { get; set; }
  }

  public class PessoaJuridica : Pessoa
  {
    public string CNPJ { get; set; }
  }
}
