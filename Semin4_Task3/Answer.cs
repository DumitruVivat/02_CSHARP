using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin4_Task3
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("Input the size of array: ");
      int n = Convert.ToInt32(Console.ReadLine());

      if (n < 1 || n > 8)
      {
        Console.WriteLine("Incorerct Input");
        return;
      }
      int[] arr = CreateArrayRandInt(n, 0, 10);
      PrintArray(arr);
      int result = ArrayToNumber(arr);
      Console.WriteLine($" => {result}");

    }

    static int ArrayToNumber(int[] array)
    {
      int result = 0;
      for (int i = 0; i < array.Length; i++)
      {
        result = result * 10 + array[i];
      }
      return result;
    }
    static void PrintArray(int[] array)
    {
      Console.Write("[");
      for (int i = 0; i < array.Length; i++)
      {
        if (i < array.Length - 1)
        {
          Console.Write($"{array[i]}, ");
        }
        else
        {
          Console.Write($"{array[i]}");
        }
      }
      Console.Write("]");
    }
    static int[] CreateArrayRandInt(int size, int min, int max)
    {
      int[] array = new int[size];
      Random random = new Random();

      for (int i = 0; i < size; i++)
      {
        array[i] = random.Next(min, max);
      }
      return array;
    }
  }
}