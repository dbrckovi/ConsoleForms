// using ConsoleFormsLib;

namespace ConsoleFormsTest;


class Program
{
  static void Main(string[] args)
  {
    Diagnostics();
    // Console.WriteLine("\u001b[38;2;255;0;0mThis is red text");
    // Console.WriteLine("\u001b[48;2;0;255;0mThis has a green background\u001b[0m");
    // Console.WriteLine("\u001b[38;2;255;255;0mYellow text on default background\u001b[0m");
  }

  static void Diagnostics()
  {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    
    PerformDiagnostic("BufferHeight, BufferWidth", new Action(() => { Console.Write($"{Console.BufferHeight}, {Console.BufferWidth}");} ));
    PerformDiagnostic("CapsLock", new Action(() => { Console.Write($"{Console.CapsLock}");} ));
    PerformDiagnostic("Beep", new Action(() => { Console.Beep(); } ));
    PerformDiagnostic("CursorLeft", new Action(() => { Console.Write($"{Console.CursorLeft}");} ));
    PerformDiagnostic("CursorTop", new Action(() => { Console.Write($"{Console.CursorTop}");} ));
    PerformDiagnostic("CursorSize", new Action(() => { Console.Write($"{Console.CursorSize}");} ));
    PerformDiagnostic("CursorVisible", new Action(() => { Console.Write($"{Console.CursorVisible}");} ));
    PerformDiagnostic("GetCursorPosition", new Action(() => { Console.Write($"{Console.GetCursorPosition()}");} ));
    PerformDiagnostic("InputEncoding", new Action(() => { Console.Write($"{Console.InputEncoding}");} ));








    // Console.WriteLine($"Caps lock: {Console.CapsLock}");
    // Console.WriteLine($"BufferWidth: {Console.BackgroundColor}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"BufferWidth: {Console.BufferWidth}");
    // Console.WriteLine($"Redirected: {Console.IsOutputRedirected}");
    // Console.WriteLine("BEEP"); Console.Beep();
  }

  private static void PerformDiagnostic(string name, Action action)
  {
    Console.Write($"{name}: ");
        
    try
    {
      action.Invoke();
    }
    catch (Exception ex)
    {
      Console.Write(ex.Message);
    }
    Console.WriteLine();
  }
}
