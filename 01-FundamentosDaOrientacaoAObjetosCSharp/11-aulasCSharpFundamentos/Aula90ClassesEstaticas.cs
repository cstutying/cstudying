// CLASSES ESTÁTICAS

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Pagamento.Vencimento = DateTime.Now;
      Console.WriteLine("Ola");
    }
  }
  public static class Pagamento
  {
    public static DateTime Vencimento { get; set; }
  }
  public static class Settings
  {
    // IDEAL PARA QUEM VAI USAR SITE
    public static string API_URL { get; set; }
  }
}
