using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin2_Task3
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("insput first number: ");
      int firstNumber = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("insput second number: ");
      int secondNumber = Convert.ToInt32(Console.ReadLine());

      int remainder = firstNumber % secondNumber;

      if (remainder == 0)
      {
        Console.WriteLine("Yes");
      }
      else
      {
        Console.WriteLine("No, " + remainder);
      }
    }
  }
}