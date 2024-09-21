using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork6_Task1
{
  public class Answer
  {
    static void Main()
    {
      char[,] charMatrix = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
      string result = CreateStringFormat2DArray(charMatrix);
      Console.WriteLine(result);
    }
    static string CreateStringFormat2DArray(char[,] matrix)
    {
      string result = "";

      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i,j];
        }
      }
      return result;
    }
  }
}