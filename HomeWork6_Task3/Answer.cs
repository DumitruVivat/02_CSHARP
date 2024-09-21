using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork6_Task3
{
  public class Answer
  {
    static void Main()
    {
      string input = "natan";
      bool isPalindrome = IsPalindrome(input);

      Console.WriteLine(isPalindrome ? "YES" : "NO");
    }

    static bool IsPalindrome(string str)
    {
      // string normalized = new string(str.Where(char.IsAsciiLetterOrDigit).ToArray()).ToLower();
      // return normalized.SequenceEqual(normalized.Reverse());

      // str = str.Replace(" ", "").ToLower();

      // char[] charArray = str.ToCharArray();
      // Array.Reverse(charArray);
      // string reversed = new string(charArray);

      // return str == reversed;
      int length = str.Length;

      for (int i = 0; i < length / 2; i++)
      {
        if (str[i] != str[length - 1 - i])
        {
          return false;
          break;
        }
      }
      return true;
    }
  }
}