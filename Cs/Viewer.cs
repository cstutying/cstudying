using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Cs
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO VISUALIZAÇÃO");
      Console.WriteLine("----------");
      Replace(text);
      Console.WriteLine("----------");
      Console.ReadKey();
      Menu.Show();

    }

    public static void Replace(string text)
    {
      //REGEX BASICAMENTE É UMA STRING QUE SUBSTITUI OUTRA STRING SÓ QUE (DE MUITAS FORMAS DIFERENTE)
      //EX QUERO QUE ELE PEGUE TUDO QUE ESTA ENTRE STRONG E BARRA STRONG E TRAGA ESSE TEXTO PARA MIM
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' '); // USAR ASPAS SIMPLES

      for (var i = 0; i < words.Length; i++)
      {
        if (strong.IsMatch(words[i]))
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write(
            words[i].Substring(
              words[i].IndexOf('>') + 1,  // USAR ASPAS SIMPLES
              (
                (words[i].LastIndexOf('<') - 1) - // USAR ASPAS SIMPLES
                words[i].IndexOf('>') // USAR ASPAS SIMPLES
              )
            )
          );
          Console.Write(" "); // USAR ASPAS DUPLAS
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Write(words[i]);
          Console.Write(" "); // USAR ASPAS DUPLAS
        }
      }
    }
  }
}