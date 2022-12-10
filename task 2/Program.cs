// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(Math.Max(a,b), c);
Console.WriteLine($"Максимальное число: {max}");