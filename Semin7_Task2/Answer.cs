using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Semin7_Task2
{
  public class Answer
  {
    static void Main()
    {
      //   Console.WriteLine(Factorial(5));
      Console.WriteLine(SumOfDigits(12345));
    }
    // static int Factorial(int n)
    // {
    //   if (n == 1 || n == 0) return 1;
    //   return n * Factorial(n - 1);
    // }
    static int SumOfDigits(int num)
    {
      if (num == 0) return 0;
      return num % 10 + SumOfDigits(num / 10);
    }
  }
}