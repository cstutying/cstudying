// CONVERSÃO EXPLICITA
// Ocorre quando tipos nao são compatíveis 
// É dada pelo uso do tipo entre parênteses antes da atribuição
// Segui as mesmas regras anteriores

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int inteiro = 100;
      uint inteiroSemSinal = (uint)inteiro; // CONVERSÃO EXPLICITA

    }
  }
}