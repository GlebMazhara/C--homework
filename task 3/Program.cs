// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if ( a % 2 == 0)
    Console.WriteLine($"Число чётное: {a} ");
else
    Console.WriteLine($"Число не чётное: {a}");