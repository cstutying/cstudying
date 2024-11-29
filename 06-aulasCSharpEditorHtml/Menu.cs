using System;
using System.Collections;
using System.Diagnostics;

namespace aulasCSharpEditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Black; // COR DO FUNDO (BLUE)
      Console.ForegroundColor = ConsoleColor.Black; // COR DA LETRA (PRETO)  

      DrawScreen();
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandLeMenuOption(option);
    }

    public static void DrawScreen() // DESENHA A TELA
    {
      Console.Write("+"); // "+------------------------------+"
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

      for (int lines = 0; lines <= 10; lines++)
      {
        Console.Write("|"); // "|                              |" VAI FAZER POR 10VEZES
        for (int i = 0; i <= 30; i++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }

      Console.Write("+"); // "+------------------------------+"
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");
    }

    public static void WriteOptions() // ESCREVE AS OPÇÃO PARA O USUÁRIO
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("===========");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    //QUANDO QUISER MANIPULAR UM CLICK OU ALGO ESCREVA (HandLeMenuOption)
    public static void HandLeMenuOption(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break; // CHAMA O EDITOR.CS PARA O MENU.CS
        case 2: Console.WriteLine("View"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }
  }
}