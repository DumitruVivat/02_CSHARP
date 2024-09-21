using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin6_Task2
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("Input text: ");
      string hello = Console.ReadLine();
      char[] stringArray = StringToCharArray(hello);
      printArray(stringArray);
    }
    static char[] StringToCharArray(string s)
    {
      char[] array = new char[s.Length];
      for (int i = 0; i < s.Length; i++)
      {
        array[i] = s[i];
      }
      return array;
    }
    static void printArray(char[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]} ");
      }
    }
  }
}