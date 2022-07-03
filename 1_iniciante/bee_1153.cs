using System;

namespace beecrowd.iniciante
{
  public class bee_1153
  {
    public static void Main(string[] args)
    {
      int valorFatorial = Int32.Parse(Console.ReadLine());
      Console.WriteLine(Fatorial(valorFatorial));
    }

    private static int Fatorial(int fator)
    {
      if (fator == 1)
      {
        return 1;
      }
      return fator * Fatorial(fator - 1);
    }
  }
}