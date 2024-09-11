using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomwWork3_Task1
{
  public class Answer
  {
    static void Main()
    {
      int[] numbers = { 1, 3, 4, 19, 3 };
      int numberToFind = 3;

      if (isNumberPresnt(numbers, numberToFind))
      {
        Console.WriteLine("Presented");
      }
      else
      {
        Console.WriteLine("Not present");
      }
    }

    static bool isNumberPresnt(int[] numbers, int numberToFind)
    {
      foreach (int number in numbers)
      {
        if (number == numberToFind)
        {
          return true;
        }
      }
      return false;
    }
  }
}