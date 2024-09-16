using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Semin4_Task1
{
  public class Answer
  {
    static void Main()
    {
      int[] arr = CreateArrayRandInt(10, 1, 100);
      PrintArray(arr);
      int countPrime = CountPrimeNumbers(arr);
      Console.Write($" => {countPrime}");
    }

    static bool isPrime(int num)
    {
      for (int i = 2; i <= Math.Sqrt(num); i++)
      {
        if (num % i == 0) return false;
      }
      return true;
    }
    static int CountPrimeNumbers(int[] array)
    {
      int count = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (isPrime(array[i]))
        {
          count++;
        }
      }
      return count;
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
  }
}