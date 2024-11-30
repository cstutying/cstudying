// LAÇOS DE REPETIÇÃO FOR
// Tradução "PARA", ou seja, para cada item um valor...
// Executa uma determinada ação várias vezes
// Exige 3 Parâmetros FOR
/* CONTADOR 
   CONDIÇÃO
   INCREMENTO
*/

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 1
      // for (int i = 0; i <= 5; i++) // 0 A 5
      // for (int i = 1; i <= 5; i++) // 1 A 5
      // for (int i = 0; i < 5; i++) // 0 A 4
      for (int i = 5; i >= 0; i--) // 5 A 0
      {
        Console.WriteLine(i);
      }

      // EXEMPLO 2
      /* // CONTA DE 0 A 5
      for (var i = 0; i <= 5; i++) ;

      // CONTA DE 1 A 5
      for (var i = 1; i <= 5; i++) ;

      // CONTA DE 0 A 4;
      for (var i = 0; i < 5; i++) ;

      // CONTA DE 5 A 0;
      for (var i = 5; i >= 0; i--) ;

      // CONTA DE 0 A 5;
      for (var i = 0; i <= 5; i++) ; */

    }

  }
}
