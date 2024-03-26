using System;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;

namespace Editor_HTML
{
  public static class Editor
  {
    // Método Show
    public static void Show()
    {
      Console.Clear();

      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.White;

      Console.Clear();

      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("===========");

      Start();
    }

    // Método Start
    public static void Start()
    {
      // Fazer com que o usuário possa adicionar muitos caracteres
      var texto = new StringBuilder();

      do
      {
        texto.Append(Console.ReadLine());
        texto.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("-----------------------");
      Console.WriteLine("Deseja salvar o arquivo? \n" +
                        "1 - Sim \n" +
                        "2 - Não \n");
      Console.Write("Opção: ");

      int opcao = int.Parse(Console.ReadLine()!);

      switch (opcao)
      {
        case 1:
          Salvar_Arquivo(texto);
          break;
        case 2:
          Menu.Show();
          break;
      }

    }

    // Método Salvar_Arquivo
    public static void Salvar_Arquivo(StringBuilder texto)
    {
      Console.WriteLine("Digite o caminho para ser salvo: ");
      var path = Console.ReadLine()!;

      using (var file = new StreamWriter(path))
      {
        file.Write(texto);
      }

      Console.WriteLine($"Arquivo {path} salvo com sucesso");
      Console.ReadLine();

      Menu.Show();
    }

  }

}



