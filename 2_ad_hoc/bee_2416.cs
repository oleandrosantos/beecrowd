using System;

namespace beecrowd.ad_hoc
{
  public class bee_2416
  {
    public static void Main(string[] args)
    {
      string[] dados = Console.ReadLine().Split(' ');
      var rest = Int32.Parse(dados[0]) % Int32.Parse(dados[1]);
      Console.WriteLine(rest);
    }
  }
}