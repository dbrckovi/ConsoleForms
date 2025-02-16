namespace ConsoleFormsLib;

public class Class1
{
  ///<summary>Indicates that test was called</summary>
  public void Test(string p)
  {
    Console.WriteLine("test called");
    Console.WriteLine($"Some other line called {p}");
  }
}
