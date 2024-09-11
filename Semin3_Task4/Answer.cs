using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin3_Task4
{
  public class Answer
  {
    static void Main()
    {
      int num;
      Console.WriteLine("Input number: ");
      num = Convert.ToInt32(Console.ReadLine());
      // creating count for array lenght
      int numCopy = num;
      int count = 0;
      while(numCopy != 0)
      {
        numCopy /= 10;
        count++;
      }

      int[] arr = new int[count]; // creating array with size of count
      int index = arr.Length -1; // index of last eliment
      while (num != 0)
      {
        arr[index] = num % 10;
        num /= 10; 
        index--;
      } 
      Console.Write("[");
      foreach (int i in arr)
      {
        Console.Write($"{i} ");
      }
      Console.Write("]");
    }
  }
}