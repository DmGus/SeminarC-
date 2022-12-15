// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число и нажмите ENTER");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число и нажмите ENTER");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine($"Число {a} равно числу {b}");
}
else if (a > b )
{
    Console.WriteLine($"Число {a} - большее, число {b} - меньшее");
}
else
{
    Console.WriteLine($"Число {b} - большее, число {a} - меньшее");
}