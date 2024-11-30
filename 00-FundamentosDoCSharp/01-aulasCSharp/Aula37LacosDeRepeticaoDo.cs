// LAÇOS DE REPETIÇÃO (DO:(FAÇA) REALIZA UMA AÇÃO ENQUANTO)
// Definido pela palavra DO/WHILE
// EXIGE apenas uma condição no WHILE
// Checa a condição DEPOIS de executar

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 1
      int valor = 0;
      do
      {
        Console.WriteLine(valor);
        valor++;
      } while (valor <= 5);

      // EXEMPLO 2
      /* var valor = 0;
      do
      {
        Console.WriteLine("Esse é um valor DO/WHILE: " + valor);
        valor++;
      } while (valor < 5); */
    }
  }
}
