// 1. Напишите программу, которая на вход принимает
// на вход два числа и проверяет, является ли 
// первое число квадратом второго


Console.WriteLine("Введите первое целое число и нажмите ENTER");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число и нажмите ENTER");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a} НЕ является квадратом числа {b}");
}