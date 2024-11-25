// MÉTODOS ADICIONAIS

using System;
using System.Runtime.InteropServices;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = " Este texto é um teste ";
      Console.WriteLine(texto.Replace("Este", "isto"));
      Console.WriteLine(texto.Replace("xxxxx", "X"));

      // MÉTODO SPLIT
      var divisao = texto.Split(" ");
      Console.WriteLine(divisao[0]);
      Console.WriteLine(divisao[1]);
      Console.WriteLine(divisao[2]);
      Console.WriteLine(divisao[3]);

      // SUBS STRING
      // var resultado = texto.Substring(5, 5);
      var resultado = texto.Substring(5, texto.LastIndexOf("o"));
      Console.WriteLine(resultado);

      Console.WriteLine(texto.Trim()); // SEM ESPAÇO NO COMEÇO E SEM ESPAÇO NO FINAL EX: " Este texto é um teste "
    }
  }
}

