// OPERADORES DE ATRIBUIÇÃO
// Utilizamos igual para atribuir um valor 
// Porem, podemos utilizar igual junto a um operador aritmético
// X += 5 é o mesmo que X = X + 5

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 0; // ATRIBUIÇÃO
      x += 5; // x = x + 5;
      x -= 1; // x = x - 1;
      x *= 10; // x = x * 10;
      x /= 2; // x = x / 2;

      // Console.WriteLine(x);
    }
  }
}
