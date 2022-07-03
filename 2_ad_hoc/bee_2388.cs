using System;
using System.Collections.Generic;
using System.Linq;

namespace beecrowd.ad_hoc
{
  public class bee_2388
  {
    public static void Main(string[] args)
    {
      int indice = Int32.Parse(Console.ReadLine());
      int distanciaPercorrida = 0;
      for (int x = indice; x > 0; x--)
      {
        string[] dados = Console.ReadLine().Split(' ');
        distanciaPercorrida += Int32.Parse(dados[1]) * Int32.Parse(dados[0]);
      }
      Console.WriteLine(distanciaPercorrida);
    }
  }
}