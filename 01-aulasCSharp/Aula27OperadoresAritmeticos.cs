// OPERADORES ARITMÉTICOS
// Multiplicação e divisão são executados primeiro
// Caso queira executar em outra ordem, usar parenteses
// Aceitar short, int, float, double, decimal

// soma => + // SOMA
// subtração => - // SUBTRAÇÃO 
// multiplicação => * // MULTIPLICAÇÃO
// divisão => / // DIVISÃO
// modulo => % // RESTO DE DIVISÃO

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int soma = 25 + 22; // 47
      int subtracao = 25 - 22; // 3
      int divisao = 25 * 22; // 550
      int multiplcacao = 22 / 5; // 4 - FOI ARREDONDADO

      // UTILIZAMOS PARENTESES PARA REDEFINIR A ORDEM DE EXECUÇÃO
      int x = 2 + 2 * 2; // 6
      int y = 2 + (2 * 2); // 6 MESMO ANTERIOR 
      int z = (2 + 2) * 2; // 8 EXECUTOU A SOMA PRIMEIRO

      Console.WriteLine(y);
    }
  }
}
