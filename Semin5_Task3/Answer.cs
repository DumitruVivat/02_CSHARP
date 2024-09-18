using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin5_Task3
{
  public class Answer
  {
    static void Main()
    {
      int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);
      PrintMatrix(array2d);

      double[] array = GetAverageRows(array2d);

      foreach (double avg in array)
      {
        Console.WriteLine($"avg => {avg}");
      }

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
    static double[] GetAverageRows(int[,] matrix)
    {
      double[] average = new double[matrix.GetLength(0)];

      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          sum += matrix[i, j];
        }
        average[i] = (double)sum / matrix.GetLength(1);
      }
      return average;
    }
  }
}