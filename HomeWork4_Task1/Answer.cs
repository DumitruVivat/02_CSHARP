using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4_Task1
{
  public class Answer
  {
    static void Main()
    {
      while (true)
      {
        Console.Write("Input even number or 'q' to stop the loop: ");
        string input = Console.ReadLine();

        if (input == "q" || input == "Q")
        {
          Console.WriteLine("Exit from program");
          break;
        }

        bool isNumber = true;
        int number = 0;

        foreach (char c in input)
        {
          if (c < '0' || c > '9')
          {
            isNumber = false;
            break;
          }
        }
        if (isNumber)
        {
          number = 0;
          foreach (char c in input)
          {
            number = number * 10 + (c - '0');
          }

          if (IsSumOfDigitsEven(number))
          {
            Console.WriteLine($"Number {number} is even.");
            break;
          }
          else
          {
            Console.WriteLine($"Number {number} is odd.");
          }
        }
        else
        {
          Console.WriteLine("Неверный ввод, попробуйте еще раз.");
        }
      }
    }
    static bool IsSumOfDigitsEven(int number)
    {
      int sum = 0;
      int temp = number;

      while (temp > 0)
      {
        sum += temp % 10;
        temp /= 10;
      }

      return sum % 2 == 0;
    }
  }
}