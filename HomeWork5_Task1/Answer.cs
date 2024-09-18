using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork5_Task1
{
  public class Answer
  {
    static void Main()
    {
      int[,] array ={
                    { 1, 3, 5, 7 },
                    { 2, 4, 6, 8 },
                    { 9, 10, 11, 12 }
                    };

      FindMaxInRows(array);

    }
    static void FindMaxInRows(int[,] array)
    {
      int rows = array.GetLength(0);
      int cols = array.GetLength(1);

      for(int i = 0; i < rows; i++)
      {
        int max = array[i, 0];
        for(int j = 0; j < cols; j++)
        {
            if(array[i, j] > max)
            {
                max = array[i, j];
            }
        }
        Console.WriteLine($"Maximum element in the row: {i}: {max}");
      }
    }
  }
}