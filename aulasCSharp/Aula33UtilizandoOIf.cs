// UTILIZANDO O IF

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int idade = 18;
      int maioridade = 22;
      int idadeMaxima = 65;

      // if (25 == 32)
      // if (25 != 32)
      // if (idade >= maioridade && idade < idadeMaxima)
      // if (idade >= maioridade || idade < idadeMaxima)
      // if (idade >= maioridade != idade < idadeMaxima)
      // if (!(idade >= idadeMaxima)) // "!" ELA PEDE SEMPRE O FALSE
      // if (idade <= idadeMaxima) // <= CONDIÇÃO MENOR DE IDADE
      if (idade >= maioridade) // <= CONDIÇÃO MAIOR DE IDADE
      { // return; SERVE PARA PAUSAR A EXECUÇÃO DO PROGRAMA
        Console.WriteLine("É Diferente");
      }
      else if (idade >= 25) // A IDADE É MAIOR OU IGUAL A 25
      {
        Console.WriteLine("É Igual");
      }
      else if (idade >= 32) // A IDADE É MAIOR OU IGUAL A 32
      {
        Console.WriteLine("É Igual");
      }
      else if (idade >= 38) // A IDADE É MAIOR OU IGUAL A 38
      {
        Console.WriteLine("É Igual");
      }
      else
      {
        Console.WriteLine("É Igual");
      }
      Console.WriteLine("Finalizou o programa!");
    }
  }
}
