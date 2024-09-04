// string num1str = Console.ReadLine();
// int num = Convert.ToInt32(num1str);

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
  Console.WriteLine("First number is square of second number");
}
else
{
  Console.WriteLine("First numer is not squer of second number");
}
