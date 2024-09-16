using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace Semin4_Task2
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("Input the size of array: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int[] arr = CreateArrayRandInt(n, 1, 100);
      PrintArray(arr);
      int result = CountNumbsLastADivB(arr, 1, 7);
      Console.Write($" => {result}");
    }

    static int CountNumbsLastADivB(int[] array, int aLast, int bDiv)
    {
      int count = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 10 == aLast && array[i] % bDiv == 0)
        {
          count++;
        }
      }
      return count;
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