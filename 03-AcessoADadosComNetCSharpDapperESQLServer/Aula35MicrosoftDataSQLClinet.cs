using System; // PARA USAR O WriteLine DEVE USA O using system;
using Microsoft.Data.SqlClient;

namespace CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      const string connectionString = "Server=localhost,1433;Database=CSharp;User Id=sa;Password=SuaSenha";

      using (var connection = new SqlConnection())
      {
        Console.WriteLine("Conectado");
      }
      //var connection = new SqlConnection();
      //ABRIR A CONEXÃO (SQL SERVER)
      //connection.Open();
      //FECHAR A CONEXÃO (SQL SERVER)
      //connection.Open();
      Console.WriteLine("Hello World!");
    }
  }
}