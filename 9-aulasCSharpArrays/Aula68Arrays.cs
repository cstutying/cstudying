// ARRAYS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      // ALÉM DO int PODE POR também UMA string, bool
      // var meuArray = new int[5] { 23, 42, 54, 67, 99 };

      // FORMATO (STRUCT) TAMBÉM QUE PARA USAR NO ARRAY 
      var meuArray = new Teste[2];
      meuArray[0] = new Teste();

      Console.WriteLine(meuArray[0].Id);

      // Console.WriteLine(meuArray[0]);
      // Console.WriteLine(meuArray[1]);
      // Console.WriteLine(meuArray[2]);
      // Console.WriteLine(meuArray[3]);
      // Console.WriteLine(meuArray[4]);
    }
  }
  struct Teste
  {
    public int Id { get; set; }
  }
}
