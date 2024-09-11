using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Semin2_Task2
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("Input hundred number:");
      int num = Convert.ToInt32(Console.ReadLine());

      if (num >= 100 && num <= 999)
      {
        int secondDigit = num / 10 % 10;
        int lastDigit = num % 10;
        int result = secondDigit;
        int count = 1;
        while(count < lastDigit){
            result *= secondDigit;
            count++;
        }
        Console.WriteLine(result);
      }
      else
      {
        Console.WriteLine("Wrong input!");
      }
    }
  }
}