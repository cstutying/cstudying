// DISPARANDO EXCEÇÕES

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
        // Error: System.IndexOutOfRangeException
        // for (var index = 0; index < 10; index++)
        // {
        //     Console.WriteLine(arr[index]);
        // }

        Cadastrar("");
      }
      // SEMPRE VAI TRATAR OS ERRO DO MAIS ESPECIFICO PARA O MAIS GENÉRICO
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não encontrei o índex na lista");
      }
      // (SE O ERRO ESTIVER FORA DO INDEX É EXCEÇÃO)
      catch (ArgumentNullException ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Falha ao cadastrar o texto");
      }
      // (SE DER ERRO AO SALVAR O ARQUIVO É GENÉRICA)
      catch (Exception ex)
      {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Ops, algo deu errado!");
      }
    }

    private static void Cadastrar(string texto)
    {
      //"IF" SIGNIFICA "SE"
      if (string.IsNullOrEmpty(texto))
        //THROW SIGNIFICA ARREMESSAR / EXCEÇÃO / ANORMAL
        // throw new Exception("O texto não pode ser nulo ou vazio");

        // NÃÕ PRECISA SER NECESSARIAMENTE UMA EXCEPTION DE EXCEÇÃO TEM OUTRAS
        throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
    }
  }
}