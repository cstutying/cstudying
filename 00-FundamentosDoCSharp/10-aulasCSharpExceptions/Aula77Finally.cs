// FINALLY

using System;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[3];

      try
      {
        Cadastrar("testando");
      }

      // SEMPRE VAI TRATAR OS ERRO DO MAIS ESPECIFICO PARA O MAIS GENÉRICO
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não encontrei o index na lista");
      }

      // (SE O ERRO ESTIVER FORA DO INDEX É EXCEÇÃO)
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Falha ao cadastrar o texto");
      }

      // EXCEÇÃO CUSTOMIZADA ":" EXCEPTION (LEMBRA-SE QUE É DA MAIS ESPECIFICA PARA MAIS GENÉRICA)
      catch (MinhaException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.QuandoAconteceu);
        Console.WriteLine("Exceção Customizada");
      }

      // (SE DER ERRO AO SALVAR O ARQUIVO É GENÉRICO)
      catch (Exception ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ops, algo deu errado!");
      }
      // FINALLY (FINALMENTE) EXECUTAR INDEPENDENTE SE DER CERTO OU ERRADO NOSSA APLICAÇÃO
      finally
      {
        Console.WriteLine("Chegou ao fim!");
      }
    }

    private static void Cadastrar(string texto)
    {
      // "IF" SIGNIFICA "SE"
      if (string.IsNullOrEmpty(texto))
        throw new MinhaException(DateTime.Now);
    }

    // EXCEÇÃO CUSTOMIZADA ":" EXCEPTION (LEMBRA-SE QUE É DA MAIS ESPECIFICA PARA MAIS GENÉRICA)
    public class MinhaException : Exception
    {
      public MinhaException(DateTime date)
      {
        QuandoAconteceu = date;
      }

      public DateTime QuandoAconteceu { get; set; }
    }
  }
}
