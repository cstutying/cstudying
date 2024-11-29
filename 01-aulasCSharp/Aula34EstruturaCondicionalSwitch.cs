// ESTRUTURA CONDICIONAL SWITCH
// Utilizada quando temos muitas decisões
// Executando em cascata
// Devemos parar manualmente a execução com o comando break
// Possui uma execução padrão chamada DEFAULT

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 1
      bool? valor = true; // VERDADEIRO
      // bool? valor = false; // FALSO
      // bool? valor = null; // NULO
      switch (valor)
      {
        case true:
          Console.WriteLine("Verdadeiro!");
          break;
        case false:
          Console.WriteLine("Falso!");
          break;
        default:
          Console.WriteLine("Nulo!");
          break;
      }

      // EXEMPLO 2
      string soma = "Christian"; // É ESTE O CARA
      // string soma = "Marcelo"; // NÃO É O CARA
      // string soma = "Douglas"; // NÃO É O CARA
      switch (soma)
      {
        case "joão":
          Console.WriteLine("Não é o cara!");
          break;
        case "Marcelo":
          Console.WriteLine("Não é o cara!");
          break;
        case "Christian":
          Console.WriteLine("É Este o cara!");
          break;
        default:
          Console.WriteLine("Não Encontrei!");
          break;
      }

      // EXEMPLO 3
      int calculo = 12;
      switch (calculo)
      {
        case 1:
          Console.WriteLine("Num 1");
          break;
        case 2:
          Console.WriteLine("Num 2");
          break;
        case 3:
          Console.WriteLine("Num 3");
          break;
        case 4:
          Console.WriteLine("Num 4");
          break;
        default:
          Console.WriteLine("Nenhum Numero"); // SE NÃO FOR 1,2,3 OU 4
          break;
      }
    }
  }
}
