using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Semin5_Task2
{
  public class Answer
  {
    static void Main()
    {
      int[,] array2d = CreateMatrixRndInt(5, 5, 1, 10);
      PrintMatrix(array2d);
      Console.WriteLine();
      int result = SumMainOfDiagonal(array2d);
      Console.WriteLine(result);

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

    static int SumMainOfDiagonal(int[,] matrix)
    {
      int sum = 0;
      int minSize = matrix.GetLength(0);

      for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
      {
        sum += matrix[i, i];
      }
      return sum;
    }
  }
}