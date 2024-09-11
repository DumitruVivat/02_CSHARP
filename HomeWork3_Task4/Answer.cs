using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork3_Task4
{
  public class Answer
  {
    static int[] RemoveNegatives(int[] numbers)
    {
      int count = 0;

      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] >= 0)
        {
          count++;
        }
      }

      int[] result = new int[count];
      int index = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] >= 0)
        {
          result[index] = numbers[i];
          index++;
        }
      }

      return result;
    }
    static void Main(string[] args)
    {
      int[] numbers = { 5, -3, 9, -1, 2, -7, 0 };
      int[] result = RemoveNegatives(numbers);
      Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
  }
}