using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Semin2_Task1
{
  public class Answer
  {
    static void Main()
    {
      Console.Write("Input hundred number:");
      int num = Convert.ToInt32(Console.ReadLine());

      if (num >= 100 && num <= 999)
      {
        int firstDigit = num / 100; //256 / 100 = 2.56
        int thirdDigit = num % 10; // 256 % 10 = 250 + 6 = 6

        int result = firstDigit * 10 + thirdDigit;

        Console.WriteLine(result);
      }
      else
      {
        Console.WriteLine("Wrong input!");
      }
    }
  }
}