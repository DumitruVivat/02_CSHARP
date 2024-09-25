using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin7_Task3
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("Input some text: ");
      string text = Console.ReadLine();
      Console.WriteLine();
      PrintConsolants(text);
    }
    static void PrintConsolants(string str, int index = 0)
    {
      if (index == str.Length)
      {
        return;
      }
      IsConsolants(str, index);
      PrintConsolants(str, index + 1);
    }

    private static void IsConsolants(string str, int index)
    {
      string consolants = "aeiou";
      if (char.IsAsciiLetter(str[index]) && !consolants.Contains(str[index]))
      {
        Console.Write($"{str[index]}");
      }
    }
  }
}