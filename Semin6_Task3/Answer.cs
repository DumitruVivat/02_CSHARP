using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin6_Task3
{
  public class Answer
  {
    static void Main()
    {
      Console.WriteLine("Input text: ");
      string text = Console.ReadLine();
      int vowelCount = CountVowels(text);
      Console.WriteLine("Number of vowels: " + vowelCount);
    }

    static int CountVowels(string s)
    {
      int count = 0;
      string vowels = "aeiouyAEIOUY";

      //   foreach (char c in s)
      //   {
      //     if (vowels.Contains(c))
      //     {
      //         count++;
      //     }
      //   }
      for (int i = 0; i < s.Length; i++)
      {
        for (int j = 0; j < vowels.Length; j++)
        {
          if (vowels[j] == s[i])
          {
            count++;
          }
        }
      }
      return count;
    }
  }
}