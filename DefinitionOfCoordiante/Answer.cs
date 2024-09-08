using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefinitionOfCoordiante
{
  public class Answer
  {
    static void Main()
    {
      Console.Write("Input coordinate point of X and Y separated by space: ");

      String[] coordinates = Console.ReadLine().Split(' ');

      int x = Convert.ToInt32(coordinates[0]);
      int y = Convert.ToInt32(coordinates[1]);

      if (x > 0 && y > 0)
      {
        Console.WriteLine("1");
      }
      else if (x < 0 && y > 0)
      {
        Console.WriteLine("2");
      }
      else if (x < 0 && y < 0)
      {
        Console.WriteLine("3");
      }
      else if (x > 0 && y < 0)
      {
        Console.WriteLine("4");
      }
      else
      {
        Console.WriteLine("The point is on the coordinate axis");

      }
    }
  }
}