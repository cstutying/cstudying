// MÉTODOS E FUNÇÕES
// Podemos segmentar nosso programa em funções
// Também conhecido como métodos
// O MAIN é um exemplo de método
// Possui um retorno, um nome e parâmetros
// Esta composição é camada de assinatura
// Começam sempre com MAIÚSCULA

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 1
      // INVOCAÇÃO DO MÉTODO
      //   MeuMetodo("C# é legal!");
      // }
      // // DEFINIÇÃO DO MÉTODO
      // static void MeuMetodo(string parametro) // VOID EM C# SIGNIFICA VAZIO
      // {
      //   Console.WriteLine(parametro);

      MeuMetodo();
      string nome = retornaNome("Christian", "Douglas");
      Console.WriteLine(nome);
    }
    // EXEMPLO 2
    static void MeuMetodo()
    {
      Console.WriteLine("C# é legal!");
    }

    static string retornaNome(
      string nome,
      string sobrenome,

      // PARAMENTOS OPCIONAIS ABAIXO!
      int idade = 26,
      bool temFilhos = false,
      double altura = 1.83
      )

    {
      return nome + " " + sobrenome + " " + "tem" + " " + idade.ToString() + " " + "Anos" + " " + "Tem Filhos" + " " + temFilhos.ToString() + " " + "Altura" + " " + altura.ToString();
    }
  }
}