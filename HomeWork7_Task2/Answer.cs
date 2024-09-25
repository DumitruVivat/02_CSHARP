using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork7_Task2
{
  public class Answer
  {
    static int Ackerman(int m, int n)
    {
      if (m == 0)
      {
        return n + 1;
      }
      else if (m > 0 && n == 0)
      {
        return Ackerman(m - 1, 1);
      }
      else if (m > 0 && n > 0)
      {
        return Ackerman(m - 1, Ackerman(m, n - 1));
      }
      return 0;

    }
    static void Main()
    {
      int m = 2;
      int n = 3;

      int result = Ackerman(m, n);
      Console.WriteLine($"A({m}, {n}) = {result}");
    }
  }
}