System.Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"max = {a}");
}
else
{
  Console.WriteLine($"max = {b}");
}