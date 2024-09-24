using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Semin7_Task1
{
  public class Answer
  {
    static void Main()
    {
        Console.WriteLine("Input a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        PrintNaturalNumbers(number);
    }

    static void PrintNaturalNumbers(int n)
    {
        if(n  == 0) return;
        PrintNaturalNumbers(n -1);
        Console.Write($"{n} ");
    }
  }
}