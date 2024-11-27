// FORMATANDO DATAS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var data = DateTime.Now;  // DATA ATUAL DO RELÓGIO

      // ANO = Y / MES = M / DIA = D / HORA = H / SEGUNDO = S / FRAÇÃO DE SEGUNDOS = ff / TIME ZONE = z
      // var formatada = String.Format("{0:yyyy/MM/dd}", data); // ELE PEGA DATA PADRÃO DOS EUA
      var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data); // ELE PEGA DATA PADRÃO DO BR
      Console.WriteLine(formatada);

    }
  }
}

