using System;
using System.Text;

namespace Cs
{
  public static class Editor
  {
    public static void Show() // MODO EM QUE O USUÁRIO VAI PODER EDITAR 
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("----------");
      Start();
    }

    public static void Start() // ENQUANTO USUÁRIO NAO APERTA A TECLA "ESC" ELE NAO SAI DO EDITOR
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("----------");
      Console.WriteLine(" Deseja salvar o arquivo?");
      Viewer.Show(file.ToString()); // CHAMA O VIEWER.CS PARA O EDITOR.CS
    }
  }
}