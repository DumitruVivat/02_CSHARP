using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semin6_Task1
{
  public class Answer
  {
    static void Main()
    {
        char[] array = {'a', 'b', 'c', 'd', 'i', 'f'};
        string result = CharArrayToString(array);
        Console.WriteLine(result);
    }

    static string CharArrayToString(char[] arr)
    {
        string res = string.Empty;
        for(int i = 0; i < arr.Length; i++)
        {
            res += arr[i];
        }
        return res;
    }
  }
}