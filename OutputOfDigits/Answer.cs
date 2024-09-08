using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutputOfDigits
{
  public class Answer
  {
    static void Main()
    {

      Console.Write("Enter a natural number N:");
      int N = Convert.ToInt32(Console.ReadLine());

      if (N < 10)
      {
        Console.WriteLine(N);
      }
      else
      {
        while (N > 0)
        {
          int currentDigit = N % 10;

          N /= 10;
          if (N > 0)
          {
            Console.Write(currentDigit + ",");
          }
          else
          {
            Console.WriteLine(currentDigit);
          }
        }
      }
    }
  }
}