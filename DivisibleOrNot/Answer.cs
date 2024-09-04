using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisibleOrNot
{
  public class Answer
  {
    static void CheckDivisibility(int firstNumber, int secondNumber)
    {
      if (secondNumber == 0)
      {
        Console.WriteLine("You can't divide by zero");
      }
      else if (firstNumber % secondNumber == 0)
      {
        Console.WriteLine("divisible");
      }
      else
      {
        Console.WriteLine("Not divisible");
      }
    }

    static public void Main(string[] args)
    {
      int firstNumber, secondNumber;
      if (args.Length >= 2)
      {
        firstNumber = int.Parse(args[0]);
        secondNumber = int.Parse(args[1]);
      }
      else
      {
        firstNumber = 10;
        secondNumber = 3;
      }
      CheckDivisibility(firstNumber, secondNumber);
    }
  }
}