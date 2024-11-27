// DATAS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      // var data = new DateTime(); // DateTime É UM STRUCTS
      var data = DateTime.Now; // DateTime.Now PEGA A DATA ATUAL(DE HOJE)
      Console.WriteLine(data);
    }
  }
}