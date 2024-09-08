using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckingMultiplicity
{
  public class Answer
  {
    static void Main()
    {
      Console.Write("Input number a: ");

      int a = Convert.ToInt32(Console.ReadLine());

      if (a % 7 == 0 && a % 23 == 0)
      {
        Console.WriteLine("yes");
      }
      else
      {
        Console.WriteLine("no");
      }
    }
  }
}