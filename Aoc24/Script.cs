namespace Aoc24;
public class Script {
  public void Log(string? msg) {
    System.Diagnostics.Debug.WriteLine(msg);
  }
}

public static class StringExt
{
  public static string nl(this string inp, string nextLine) =>
    $"{inp}\r\n{nextLine}";
}