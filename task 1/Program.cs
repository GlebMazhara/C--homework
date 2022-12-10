Console.Clear();
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
    Console.WriteLine($"Число 1 большее: {a}; Число 2 меньшее: {b}");
else if(a<b)
    Console.WriteLine($"Число 2 большее: {b}; Число 1 меньшее: {a}");
else
    Console.WriteLine("числа равны");
