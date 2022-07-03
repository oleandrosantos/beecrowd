using System;

namespace beecrowd.ad_hoc
{
  public class bee348
  {
    public static void Main(string[] args)
    {
      int qtdV = Int32.Parse(Console.ReadLine());
      int anterior = 0;
      int contador = 0;
      for (int x = 0; x < qtdV; x++)
      {
        int v = Int32.Parse(Console.ReadLine());
        if (v != anterior)
        {
          contador++;
          anterior = v;
        }
      }
      Console.WriteLine(contador);
    }
  }
}