using System; // PARA USAR O WriteLine DEVE USA O using system;
using Microsoft.Data.SqlClient;

namespace CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      "Server=DESKTOP-6DDLMCG\\SQLEXPRESS;Database=CSharp;Trusted_Connection=True;TrustServerCertificate=True;";

      using (var connection = new SqlConnection(connectionString))
      {
        Console.WriteLine("Conectado");
        connection.Open();

        using (var command = new SqlCommand())
        {
          command.Connection = connection;
          command.CommandType = System.Data.CommandType.Text;
          command.CommandText = "SELECT [Id], [Title] FROM [Category]";

          //SqlDataReader É FORMA MAIS RÁPIDA DE LER INFORMAÇÃO DO DOTNET
          var reader = command.ExecuteReader();
          while (reader.Read())
          {
            Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
          }
        }
      }

      Console.WriteLine("Hello World!");
    }
  }
}