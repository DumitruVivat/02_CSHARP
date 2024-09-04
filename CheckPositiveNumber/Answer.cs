using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckPositiveNumber
{
  public class Answer
  {
    static void CheckNumber(int number)
    {
      if (number > 0)
      {
        Console.WriteLine("positive");
      }
      else if (number < 0)
      {
        Console.WriteLine("negative");
      }
      else
      {
        Console.WriteLine("zero");
      }
    }
    static public void Main(string[] args)
    {
      int number;
      if (args.Length >= 1)
      {
        number = int.Parse(args[0]);
      }
      else
      {
        number = 0;
      }
      CheckNumber(number);
    }
  }
}