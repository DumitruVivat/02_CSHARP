using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork6_Task4
{
  public class Answer
  {
    static void Main()
    {
      string input = "Hello my world";
      string result = ReverseWords(input);
      Console.WriteLine(result);
    }

    static string ReverseWords(string str)
    {
      string[] words = str.Split(' ');
      string reverse = "";
    //   Array.Reverse(words);
    //   return string.Join(" ", words);
      for (int i = words.Length - 1; i >= 0; i--)
      {
        reverse += words[i];
        if (i != 0)
        {
          result += " ";
        }
      }
      return reverse;
    }
  }
}