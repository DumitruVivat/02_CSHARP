using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LargestDigit
{
  public class Answer
  {
    static void Main()
    {
      Console.Write("Enter a number from the range [10, 99]: ");
      int number = Convert.ToInt32(Console.ReadLine());

      if (number >= 10 && number <= 99)
      {
        int firstDigit = number / 10;
        int secondDigit = number % 10;

        int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

        Console.WriteLine(maxDigit);
      }
      else
      {
        Console.WriteLine("Error: The value entered must be an integer between 10 and 99.");
      }
    }
  }
}