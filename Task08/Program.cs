// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число и нажмите ENTER");
int num = Convert.ToInt32(Console.ReadLine());
int index = 2;


Console.WriteLine("Все чётные числа от 1 до введеного числа:");
if (num >= 2) Console.Write(index);
index+=2;

while (index <= num)
{
    Console.Write(", " + index);
    index+=2;
}