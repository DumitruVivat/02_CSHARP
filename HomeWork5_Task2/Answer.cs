using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork5_Task2
{
  public class Answer
  {
    static void Main()
    {
      int[,] array ={
                     { 1, 2, 3 },
                     { 4, 5, 6 },
                     { 7, 8, 9 },
                     { 10, 11, 12 }
                    };

      FindSumInColumns(array);

    }
    static void FindSumInColumns(int[,] array)
    {
      int rows = array.GetLength(0);
      int cols = array.GetLength(1);

      for (int j = 0; j < cols; j++)
      {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
          sum += array[i, j];
        }
        Console.WriteLine($"Sum of elements in column {j}: {sum}");
      }
    }
  }
}