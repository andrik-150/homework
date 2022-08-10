Console.WriteLine("Введите два числа ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = a;
if (a>max) max = a;
if (b>max) max = b;
Console.Write($"max = {max}");
