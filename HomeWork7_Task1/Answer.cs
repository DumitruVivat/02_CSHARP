using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork7_Task1
{
  public class Answer
  {
    static void PrintRange(int M, int N)
    {
        if(M > N) return;
        Console.Write(M);
        if(M < N) Console.Write(", ");
        PrintRange(M + 1, N);
    }
    static void Main()
    {
        int M = 1;
        int N = 9;

        Console.WriteLine("Numbers in the range: ");
        PrintRange(M, N);

    }
  }
}