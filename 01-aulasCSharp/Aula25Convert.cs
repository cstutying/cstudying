// CONVERT
// Similar ao PARSE visto anteriormente 
// Porem permite converter vários tipos de valor
// NÃO APENAS STRING
// Devemos informar o tipo na chamada da conversão

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      int inteiro = Convert.ToInt32("100");
    }
  }
}