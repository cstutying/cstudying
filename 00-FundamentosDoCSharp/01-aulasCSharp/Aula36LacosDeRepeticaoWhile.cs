// LAÇOS DE REPETIÇÃO WHILE
// While: TRADUÇÃO (enquanto), ou seja, enquanto uma condição for verdadeira, executa a ação
// Definido pela palavra WHILE
// EXIGE apenas uma condição
// Checar a condição ANTES de executar

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 0
      int valor = 0;
      while (valor <= 5)
      {
        valor++;
        Console.WriteLine(valor);
      }


      // EXEMPLO 1
      /* var valor = 0;
      // CONTA DE 0 A 5
      // EXIBE DE 0 A 5 NA TELA
      while (valor <= 5)
      {
        Console.WriteLine(valor);
        valor++;
      } */

      // EXEMPLO 2
      /* var total = 0;
      // CONTA DE 0 A 5
      // EXIBE DE 1 A 6 NA TELA
      while (valor <= 5)
      {
        valor++;
        Console.WriteLine(total);
      } */

      // EXEMPLO 3 WHILE TRUE (INFINITO)
      /*  int valor = 0;
       // INFINITO
       while (true)
       {
         valor++;
         Console.WriteLine(valor);
       } */

    }
  }
}
