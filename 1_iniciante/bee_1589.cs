using System;
using System.Collections.Generic;

namespace beecrowd.iniciante
{
  public class bee_1589
  {
    public static void Main(string[] args)
    {
      int qtdConduites = Int32.Parse(Console.ReadLine());
      List<int> MenorRaioNecesssario = new List<int>() { };
      for (int i = 1; i <= qtdConduites; i++)
      {
        string[] raios = Console.ReadLine().Split(' ');
        MenorRaioNecesssario.Add(Int32.Parse(raios[0]) + Int32.Parse(raios[1]));
      }

      foreach (var menor in MenorRaioNecesssario)
      {
        Console.WriteLine(menor);
      }
    }
  }
}