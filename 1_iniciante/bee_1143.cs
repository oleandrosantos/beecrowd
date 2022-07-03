using System;

namespace beecrowd.iniciante
{
  public class bee_1143
  {
    public static void Main(string[] args)
    {
      int valor = Int32.Parse(Console.ReadLine());
      for (int x = 1; x <= valor; x++)
      {
        Console.WriteLine($"{x} {x * x} {x * x * x}");
      }
    }
  }
}