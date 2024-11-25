// STRING E BUILDER

using System;
using System.Text;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 1
      var texto = new StringBuilder(); // RECOMENDA USAR ESSE METODO 
      texto.Append("Este texto é um teste");
      texto.Append("é um teste");
      texto.Append("Este texto");
      texto.Append("Este um teste");

      texto.ToString(); // SEMPRE USA ESSA STRING QUANDO ESTIVER EM OUTRO OBJETO
      Console.WriteLine(texto);

      // EXEMPLO 2
      // var texto = "Este texto é um teste";
      //   var texto = @"Este texto é um teste"; // USAR O @ PARA QUEBRAR LINHAS
      //   var texto2 = texto; // ESTA FAZENDO UMA COPIA 
      // texto += " aqui"; // CONCATENAÇÃO DE STRING

      // Console.WriteLine(texto);
    }
  }
}
