using System;
public class bee_2455
{
  public static void Main(string[] args)
  {
    string[] dados = Console.ReadLine().Split(' ');
    var p1 = Int32.Parse(dados[0]) * Int32.Parse(dados[1]);
    var p2 = Int32.Parse(dados[2]) * Int32.Parse(dados[3]);

    if (p1 == p2)
      Console.WriteLine(0);
    else if (p1 > p2)
      Console.WriteLine(-1);
    else
      Console.WriteLine(1);
  }
}