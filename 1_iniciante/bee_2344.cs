using System;

namespace beecrowd.iniciante
{
  public class bee_2344
  {
    public static void Main(string[] args)
    {
      int nota = Int32.Parse(Console.ReadLine());
      if (nota == 0)
        Console.WriteLine("E");
      else if (nota > 0 && nota <= 35)
        Console.WriteLine("D");
      else if (nota > 35 && nota <= 60)
        Console.WriteLine("C");
      else if (nota > 60 && nota <= 85)
        Console.WriteLine("B");
      else
        Console.WriteLine("A");

    }
  }
}