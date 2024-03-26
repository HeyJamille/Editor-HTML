using System;
using System.Text.RegularExpressions;

namespace Editor_HTML
{
  public class Viewer
  {
    public static void Show(string path)
    {
      Console.Clear();

      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.White;

      Console.Clear();

      Console.WriteLine("MODO VISUALIZAÇÃO");
      Console.WriteLine("------------------");

      using (var file = new StreamReader(path))
      {
        string texto = file.ReadToEnd();
        Console.WriteLine(texto);
      }

      Console.WriteLine("------------------");

      Thread.Sleep(3000); // Dorme por 3 segundos 
      Menu.Show();
    }

  }
}