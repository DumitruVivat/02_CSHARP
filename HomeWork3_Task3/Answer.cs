using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace HomeWork3_Task3
{
  public class Answer
  {
    static double CalculateAverage(int[] numbers)
    {
      int index = numbers.Length;
      int sum = 0;
      for (int i = 0; i < index; i++)
      {
        sum += numbers[i];
      }
      return sum / index;
    }
    static void Main(string[] args)
    {
      int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      double average = CalculateAverage(numbers);
      Console.WriteLine(average);
    }
  }
}