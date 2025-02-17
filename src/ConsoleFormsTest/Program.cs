// using ConsoleFormsLib;

namespace ConsoleFormsTest;


class Program
{
  static void Main(string[] args)
  {
    StandardColors();
    // Diagnostics();
    // Console.WriteLine("\u001b[38;2;255;0;0mThis is red text");
    // Console.WriteLine("\u001b[48;2;0;255;0mThis has a green background\u001b[0m");
    // Console.WriteLine("\u001b[38;2;255;255;0mYellow text on default background\u001b[0m");
  }

  static void StandardColors()
  {
    Console.Clear();
    int x = 0;
    int y = 0;

    foreach (ConsoleColor fc in Enum.GetValues(typeof(ConsoleColor)))
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.Black;
      Console.SetCursorPosition(0, y);
      Console.Write($"{fc.ToString()} ".PadRight(14,'─'));
    
      Console.SetCursorPosition (0, 18 + y);
      Console.Write(fc.ToString());

      for (int top = 17; top <= 17 + y; top ++)
      {
        Console.SetCursorPosition(15 + y, top);
        Console.Write("│");
      }

      for (int left = fc.ToString().Length + 1; left <= 14 + y; left++)
      {
        Console.SetCursorPosition(left, 18 + y);
        Console.Write("─");
      }
      Console.SetCursorPosition(15 + y, 18 + y);
      Console.Write("┘");

      Console.ForegroundColor = fc;
      x = 0;
      foreach (ConsoleColor bc in Enum.GetValues(typeof(ConsoleColor)))
      {
        Console.SetCursorPosition(x + 15, y);
        Console.BackgroundColor = bc;
        Console.Write("8");
        x++;
      }

      
      y++;
    }
    Console.ResetColor();
    Console.SetCursorPosition(0,40);
    Console.WriteLine();
  }
}
