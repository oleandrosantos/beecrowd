using System;

namespace beecrowd.iniciante
{
  public class bee_2061
  {
    public static void Main(string[] args)
    {
      string[] dados = Console.ReadLine().Split(' ');
      Int16 numeroDeAbas = Int16.Parse(dados[0]);
      Int16 qtdEntradas = Int16.Parse(dados[1]);
      for (int x = 0; x < qtdEntradas; x++)
      {
        if (Console.ReadLine() == "fechou")
        {
          numeroDeAbas++;
        }
        else
        {
          numeroDeAbas--;
        }
      }

      Console.WriteLine(numeroDeAbas);
    }
  }
}