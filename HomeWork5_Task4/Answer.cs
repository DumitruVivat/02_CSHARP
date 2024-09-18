using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork5_Task4
{
  public class Answer
  {
    static void Main()
    {
      int[,] matrix =
      {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, -8, 9 }
       };

      PrintMatrix(matrix);
      ReplaceNegativeNumbers(matrix);
      Console.WriteLine();
      PrintMatrix(matrix);
    }

    static void ReplaceNegativeNumbers(int[,] array)
    {
      int rows = array.GetLength(0);
      int cols = array.GetLength(1);

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          if (array[i, j] < 0)
          {
            array[i, j] = -array[i, j];
          }
        }
      }
    }

    static void PrintMatrix(int[,] array)
    {
      int rows = array.GetLength(0);
      int cols = array.GetLength(1);

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
      }
    }
  }
}