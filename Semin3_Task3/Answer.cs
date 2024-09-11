using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin3_Task3
{
  public class Answer
  {
    static void Main()
    {
      int[] array = { 1, 3, 2, 4, 2, 4, 7};
      int[] arrayResult = new int[array.Length / 2];

      int left = 0;
      int right = array.Length - 1;

      while (left < right)
      {
        arrayResult[left] = array[left] * array[right];
        left++;
        right--;
      }
      foreach(int i in arrayResult)
      {
        Console.Write($"{i} ");
      }
    }
  }
}