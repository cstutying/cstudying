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
    static void Main(string[] args) // VOID EM C# SIGNIFICA VAZIO
    {
      // EXEMPLO 1
      // DEFINIÇÃO DO MÉTODO
      // RETORNA UMA STRING E RECEBE VÁRIOS PARÂMETROS
      // static string RetornaNome(string nome, string sobrenome)
      // {
      // RETORNA O NOME E SOBRENOME
      //   return nome + " " + sobrenome;
      // }

      // EXEMPLO 2
      // INVOCAÇÃO DO MÉTODO
      MeuMetodo("C# é legal!");
    }
    // DEFINIÇÃO DO MÉTODO
    static void MeuMetodo(string parametro)
    {
      Console.WriteLine(parametro);
    }
  }
}
