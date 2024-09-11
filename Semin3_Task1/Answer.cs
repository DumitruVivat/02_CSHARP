using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin3_Task1
{
  public class Answer
  {
    static void Main()
    {
      //   int[] array1 = new int[5];
      //   int[] array2 = new int[5] { 3, 6, 7, 8, 5 };
      //   int[] array3 = new int[] { 3, 6, 7, 8, 5 };

      int[] array = { 8, 1, 3, 4, 19, 3, 8 };
      int num = 20;

      bool isExistNum = false;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == num)
        {
          isExistNum = true;
          break;
        }
      }
      Console.WriteLine(isExistNum ? "yes" : "no");
    }
  }
}