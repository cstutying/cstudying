// OBJETOS
// É COMPOSTO POR 3 ITENS
// PROPRIEDADES (ALTURA, LARGURA, PROFUNDIDADE, PESO, COR SÃO AS CARACTERÍSTICAS)
// MÉTODOS (REPRODUZIR, GRAVAR, AJUSTAR VOLUME, ROTACIONAR, ABRIR, FECHAR, CLICAR)
// EVENTOS (AO COMEÇAR GRAVAR, AO CLICAR NO MOUSE, AO ABRIR A TAMPA, AO ENCHER A GARRAFA, )

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer();
      customer.Name = "Teste";
    }
  }
  struct Customer
  {
    public string Name;
  }
}