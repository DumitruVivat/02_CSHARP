using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork3_Task2
{
  public class Answer
  {
    static void SwapSigns(int[] numbers)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        // if (i > 0)
        // {
        //   numbers[i] /= -1;
        // }
        // else
        // {
        //   numbers[i] *= -1;
        // }
        numbers[i] = -numbers[i];
      }
    }
    static void Main(string[] args)
    {
      int[] numbers = { 1, -5, 6, -7, 3 };
      SwapSigns(numbers);
      Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }
  }
}