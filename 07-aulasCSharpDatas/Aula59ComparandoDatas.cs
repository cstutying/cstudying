// COMPARANDO DATAS

using System;
using System.Runtime.InteropServices;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      // EXEMPLO 01
      // DateTime? data = null; // DateTime.Now;
      var data = DateTime.Now;

      if (data.Date == DateTime.Now.Date)
      {
        Console.WriteLine("É igual");
      }
      Console.WriteLine(data);

      // EXEMPLO 02
      var data2 = DateTime.Now; //DATE É UM VALUE TYPE (TIPO DE VALOR)
      if (data2.Date >= DateTime.Now.Date)
        Console.WriteLine("É igual");
      Console.WriteLine(data2);

    }
  }
}
