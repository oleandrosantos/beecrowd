using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estruturas_e_bibliotecas
{
  public class bee_1022
  {
    static void Main(string[] args)
    {
      int nrVezes = Int32.Parse(Console.ReadLine());
      List<string> resultado = new List<string>();

      for (int x = 0; x < nrVezes; x++)
      {
        string[] expressoes = Console.ReadLine().Split(' ');
        resultado.Add(ResolverOperacoes(expressoes));
      }
      resultado.ForEach(c => Console.WriteLine(c));
    }

    private static string Soma(int[] numeros)
    {
      int novoDeno = numeros[0] * numeros[3] + numeros[2] * numeros[1];
      int novoNume = numeros[1] * numeros[3];
      return FormatarParaImpressao(novoDeno, novoNume);
    }

    private static string Subtracao(int[] numeros)
    {
      int novoDeno = numeros[0] * numeros[3] - numeros[2] * numeros[1];
      int novoNume = numeros[1] * numeros[3];
      return FormatarParaImpressao(novoDeno, novoNume);
    }

    private static string Multiplicacao(int[] numeros)
    {
      int novoDeno = numeros[0] * numeros[2];
      int novoNume = numeros[1] * numeros[3];
      return FormatarParaImpressao(novoDeno, novoNume);
    }

    private static string Divisao(int[] numeros)
    {
      int novoDeno = numeros[0] * numeros[3];
      int novoNume = numeros[2] * numeros[1];
      return FormatarParaImpressao(novoDeno, novoNume);
    }

    private static string FormatarParaImpressao(int denominador, int numerador)
    {
      int[] numeros = new int[] { denominador, numerador };
      int[] reducao = ReduzindoNumeros(numeros);
      return $"{denominador}/{numerador} = {reducao[0]}/{reducao[1]}";
    }


    private static string ResolverOperacoes(string[] expressoes)
    {
      int[] numeros = new int[] { Int32.Parse(expressoes[0]), Int32.Parse(expressoes[2]), Int32.Parse(expressoes[4]), Int32.Parse(expressoes[6]) };
      if (expressoes[3] == "+")
      {
        return Soma(numeros);
      }
      if (expressoes[3] == "-")
      {
        return Subtracao(numeros);
      }
      if (expressoes[3] == "/")
      {
        return Divisao(numeros);
      }
      if (expressoes[3] == "*")
      {
        return Multiplicacao(numeros);
      }

      return "";
    }

    private static int[] ReduzindoNumeros(int[] numero)
    {
      if (numero[0] % 2 == 0 && numero[1] % 2 == 0)
      {
        numero[0] = numero[0] / 2;
        numero[1] = numero[1] / 2;
        ReduzindoNumeros(numero);
      }
      else if (numero[0] % 3 == 0 && numero[1] % 3 == 0)
      {
        numero[0] = numero[0] / 3;
        numero[1] = numero[1] / 3;
        ReduzindoNumeros(numero);
      }
      else if (numero[0] == numero[1])
      {
        return new int[] { 1, 1 };
      }

      return numero;
    }

  }
}