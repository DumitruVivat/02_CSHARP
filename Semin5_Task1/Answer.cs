using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin5_Task1
{
  public class Answer
  {
    static void Main()
    {
      //   int[][] arr = {{4, 3, 4, 3},
      //                    {4, 3, 4, 1},
      //                    {2, 9, 25, 4}
      //                    };
      int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
      PrintMatrix(array2d);
      Console.WriteLine();
      ElemEvenIndexesToSquare(array2d);
      PrintMatrix(array2d);
    }

    static int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
    {
      int[,] matrix = new int[rows, columns]; // 3x4
      Random rnd = new Random();

      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          matrix[i, j] = rnd.Next(min, max);
        }
      }
      return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
      }
    }

    static void ElemEvenIndexesToSquare(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i+=2)
      {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
        //   if (i % 2 == 0 && j % 2 == 0)
        //   {
            matrix[i, j] *= matrix[i, j];
        //   }
        }
      }
    }
  }
}