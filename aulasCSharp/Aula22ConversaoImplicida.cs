// É COMUM PRESARMOS TRANSFORMAR UM DADO DE TIPO X PARA TIPO Y
// Existem dois tipo de conversão, as implícitas e as explicitas
// As implícitas são conversões que
// Podem ser executas apenas com passagem de dados
// Possuem tipos compartíveis

// DEFINIÇÕES
// sbyte -> short, int, long, float, double, decimal
// byte -> short, ushort, int, uint, long, ulong, float, double, decimal
// short -> int, long, float, double, or decimal
// ushort -> int , uint, long, ulong, float, double, or decimal
// int -> long, float, double, or decimal

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      float valor = 25.8F;
      int outro = 25;

      valor = outro; // CONVERSÃO IMPLÍCITA

    }
  }
}