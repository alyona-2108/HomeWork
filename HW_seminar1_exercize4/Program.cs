System.Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

System.Console.WriteLine($"max = {max}");