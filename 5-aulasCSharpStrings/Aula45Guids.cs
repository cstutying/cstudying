// GUIDS

using System; // PARA USAR O WriteLine DEVE USA O using system;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var id = Guid.NewGuid(); // id = Guid.NewGuid(); ELE GERA UM ID NOVO
      id.ToString();

      id = new Guid("f422d2c0-ac39-4228-8bdb-f88216c9a862"); // id = new Guid("f42d20-ac39") INFORMANDO UMA STRING ELE GERA UM GUID COM ESSE "VALOR"

      // if (id == Guid.NewGuid())

      id = new Guid(); // id = new Guid(); ELE GERA UM ID COM TODO ZERO

      Console.WriteLine(id); // ELE TRANSFONA ISSO EM ID 

      // Console.WriteLine(id.ToString().Substring(0, 8)); // PEGA APENAS OS (0, 8) PRIMEIROS CARACTERES
    }
  }
}
