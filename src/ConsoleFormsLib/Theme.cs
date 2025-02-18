namespace ConsoleFormsLib;

public class Theme
{
  public static Theme Current = new Theme();
  
  public char BorderCorner_UpperLeft = '┌';
  public char BorderCorner_UpperRight = '┐';
  public char BorderCorner_BottomLeft = '└';
  public char BorderCorner_BottomRight = '┘';
  public char BorderLine_Horizontal = '─';
  public char BorderLine_Vertical = '│';
}
