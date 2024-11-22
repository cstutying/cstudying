// VALUE TYPES E REFERENCE TYPES PRATICA

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // EXEMPLO 1
      // int x = 25;
      // int y = x;
      // Console.WriteLine(x);
      // Console.WriteLine(y);

      // x = 32;
      // Console.WriteLine(x);
      // Console.WriteLine(y);


      // EXEMPLO 2
      var arr = new string[2];
      arr[0] = "Item 1";

      var arr2 = arr;

      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

      arr[0] = "Item 2";
      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);
    }
  }
}
