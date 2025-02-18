namespace ConsoleFormsLib;

public static class Graphics
{
  public static void DrawRectangle(int x, int y, int width, int height)
  {
    if (width < 2 || height < 2) throw new ArgumentException("Both width and height must be greater than 1");

    Console.SetCursorPosition(x, y);
    Console.Write(Theme.Current.BorderCorner_UpperLeft);

    Console.SetCursorPosition(x + width -1, y);
    Console.Write(Theme.Current.BorderCorner_UpperRight);

    Console.SetCursorPosition(x, y + height - 1);
    Console.Write(Theme.Current.BorderCorner_BottomLeft);

    Console.SetCursorPosition(x + width - 1, y + height - 1);
    Console.Write(Theme.Current.BorderCorner_BottomRight);

    if (width > 1)
    {
      for (int i = x+1; i < x + width -1; i++)
      {
        Console.SetCursorPosition(i, y);
        Console.Write(Theme.Current.BorderLine_Horizontal);
        Console.SetCursorPosition(i, y+ height - 1);
        Console.Write(Theme.Current.BorderLine_Horizontal);
      }

      for (int i = y + 1; i <  y + height - 1; i++)
      {
        Console.SetCursorPosition(x, i);
        Console.Write(Theme.Current.BorderLine_Vertical);
        Console.SetCursorPosition(x + width - 1, i);
        Console.Write(Theme.Current.BorderLine_Vertical);
      }
    }
  }
}
