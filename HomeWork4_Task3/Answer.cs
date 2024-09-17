using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4_Task3
{
  public class Answer
  {
    static void Main()
    {
      int[] numbers = { 1, 3, 4, 6, 7, 8 };
      int temp;
      Array.Reverse(numbers);
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.Write($"{numbers[i]} ");
      }

      Console.Write("Original array: ");
      foreach (int number in numbers)
      {
        Console.Write(number + " ");
      }

      for (int i = 0; i < numbers.Length / 2; i++)
      {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
      }

      Console.Write("\nReverse array: ");
      foreach (int number in numbers)
      {
        Console.Write(number + " ");
      }
    }
  }
}