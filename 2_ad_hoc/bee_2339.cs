using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beecrowd.ad_hoc
{
  public class bee_2339
  {
    public static void Main(string[] args)
    {
      string[] e = Console.ReadLine().Split(' ');
      int c = Int32.Parse(e[0]);
      int p = Int32.Parse(e[1]);
      int f = Int32.Parse(e[2]);
      string r = (p / c) >= f ? "S" : "N";
      Console.WriteLine(r);

    }
  }
}