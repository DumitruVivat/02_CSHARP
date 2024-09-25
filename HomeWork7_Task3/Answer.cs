using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork7_Task3
{
  public class Answer
  {
    static void PrintArrayReverse(int[] array, int index)
    {
      if (index < 0) return;
      Console.Write(array[index]);
      if (index > 0) Console.Write(", ");
      PrintArrayReverse(array, index - 1);
    }
    static void Main()
    {
      int[] array = { 1, 2, 3, 4, 5, 6 };
      Console.WriteLine("Reverse Array: ");
      PrintArrayReverse(array, array.Length - 1);
    }
  }
}