using System;

namespace TextEditor
{

  class Program
  {
    static void Main(string[] args)
    {

      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que deseja Editar?");
      Console.WriteLine("(1) - Abrir arquivo");
      Console.WriteLine("(2) - Criar um novo arquivo");
      Console.WriteLine("(0) - Sair");
      short option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Editor(); break;
        default: Menu(); break;

      }
    }
    static void Open()
    {

    }

    static void Editor()
    {

    }


  }
}