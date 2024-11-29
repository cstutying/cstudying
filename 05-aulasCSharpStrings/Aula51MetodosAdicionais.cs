// MÉTODOS ADICIONAIS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.ToLower()); // CONVERTE TODO TEXTO PARA MINUSCULO
      Console.WriteLine(texto.ToUpper()); // CONVERTE TODO TEXTO PARA MAIÚSCULO
      Console.WriteLine(texto.Insert(5, " AQUI")); // LISTA
      Console.WriteLine(texto.Remove(5, 5)); // COMEÇA NO CARACTERES 5 E REMOVE OS PRÓXIMOS 5 CARACTERES
      Console.WriteLine(texto.Length); // ELA TRAZ A QUANTIDADE DE CARACTERES QUE UMA STRING TEM
    }
  }
}