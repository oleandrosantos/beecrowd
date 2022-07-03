using System;

namespace beecrowd.ad_hoc
{
  public class bee348
  {
    public static void Main(string[] args)
    {
      int qtdEntradas = Int32.Parse(Console.ReadLine());
      int anterior = 0;
      int contador = 0;
      for (int indice = 0; indice < qtdEntradas; indice++)
      {
        int codigo = Int32.Parse(Console.ReadLine());
        if (codigo != anterior)
        {
          contador++;
          anterior = codigo;
        }
      }
      Console.WriteLine(contador);
    }
  }
}