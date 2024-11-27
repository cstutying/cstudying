// OPERADORES LÓGICOS
// Usando para operações condicionais
// Retorna SEMPRE VERDADEIRO OU FALSO
/* 
  E=and
    Deve atender TODAS as condições
    &&
  OU - or
    Se atender uma condição já retorna VERDADEIRO
    ||
  NEGAÇÃO - not 
    !
*/

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 12;
      bool entre = (x > 25) && (x < 40); // FALSE
      // bool ou = (x > 25) || (x < 40); // TRUE
      // bool negacao = !(x < 25); // FALSE

      Console.WriteLine(entre);
    }
  }
}
