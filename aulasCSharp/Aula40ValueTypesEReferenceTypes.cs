// VALUE TYPES
// A memoria é dividida em duas partes, HEAP e STACK 
// HEAP armazena os dados
// STACK armazena as referencias para os dados
// Qualquer tipo no DOT .NET é tratado como
// Tipo de referencia (REFERENCE TYPE)
// Tipo de valor (VALUE TYPE)
// Tipos de valor armazenam dados
// São armazenados em um local de memoria cha,da STACK

// REFERENCE TYPES
// Armazena o endereço do objeto que contém os dados
// Não armazena os dados em si
// São armazenados em um local de memória chamado de HEAP
// Ao assimilar uma variável
// Criará uma REFERENCIA
// Aponta para a mesma informação
// Não são independentes
// Quando não mais utilizados são marcados para exclusão
// GARBAGE COLLECTOR (COLETOR DE LIXO) passa removendo todos eles
// Classes, Objetos, Arrays

using System;
using Microsoft.VisualBasic; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // VALUE TYPES 
      int x = 25;
      int y = x; // Y É UMA COPIA DE X

      Console.WriteLine(x); // 25
      Console.WriteLine(y); // 25

      x = 32; // SOMENTE X FOI ALTERADO
      Console.WriteLine(x); // 32
      Console.WriteLine(y); // 25

      // REFERENCE TYPES
      var arr = new string[2];
      arr[0] = "Christian";
      var arr2 = arr; // NÃO CRIA UMA CÓPIA

      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

      // ALTERA AS DUAS LISTAS 
      arr[0] = "Item Alterado";
      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

    }
  }
}