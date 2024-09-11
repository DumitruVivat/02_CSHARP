using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin3_Task2
{
  public class Answer
  {
    static void Main()
    {
      int[] array = { -1, -2, 4, -5, -6, 5, 3, 2, -6, 7, -9 };

      for (int i = 0; i < array.Length; i++)
      {
        if(array[i] > 0)
        {
            array[i] = array[i] / -1;
        }
        else
        {
            array[i] = array[i] * -1;
        }
        Console.Write(array[i] + " ");
      }
    }
  }
}