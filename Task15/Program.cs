// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели, и нажмите Enter: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((num > 0 && num < 8) ? (Weekend(num) ? $"{num} -> да" : $"{num} -> нет") : "не правильный ввод");

// Console.WriteLine(WeekDay(num) ? $"{num} -> да" : $"{num} -> нет");
// if (num > 0 && num < 8) Console.WriteLine(WeekDay(num) ? $"{num} -> да" : "{num} -> нет");
// else Console.WriteLine("не правильный ввод");

bool Weekend(int number)
{
    return num == 6 || num == 7 ? true : false;
}
