using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin2_Task4
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("input number: ");
      int num = Convert.ToInt32(Console.ReadLine());

      if (num >= 100 || num <= -100)
      {
        while (num > 999 || num < -999)
        {
          num = num / 10;
        }
        int result = num % 10;
        Console.WriteLine("third digit on left side: " + result);
      }
      else
      {
        Console.WriteLine("we don't have third digit");
      }
    }
  }
}