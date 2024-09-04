using Internal;

Console.WriteLine("Input hundred digid: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
  int firstDigit = num / 100; //456 /10=4.56
  int lastDigit = num % 10; // 456 % 10 = 450+6

  int result = lastDigit + firstDigit;
  Console.WriteLine($"sum of first and last digit = {result}");
}
else
{
  Console.WriteLine("wrong input!");
}
