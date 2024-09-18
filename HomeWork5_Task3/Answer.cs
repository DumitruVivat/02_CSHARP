using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork5_Task3
{
  public class Answer
  {
    static void Main()
    {
      int[,] array ={
                       { 1, 2 },
                       { 3, 4 },
                       { 5, 6 }
                      };

      TransposeMatrix(array);

    }
    static void TransposeMatrix(int[,] array)
    {
      int rows = array.GetLength(0);
      int cols = array.GetLength(1);
      int[,] transposed = new int[cols, rows];

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          transposed[j, i] = array[i, j];
        }
      }
      
      PrintMatrix(transposed);
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