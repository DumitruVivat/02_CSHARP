Console.WriteLine("Input even number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{

  int count = -num; // num * -1

  while (count <= num)
  {
    Console.Write(count + " ");
    count++;
  }
}
else
{
  Console.WriteLine("Wrong input number!");
}
