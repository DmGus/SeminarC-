// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число и нажмите Enter: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondDigit(num) == -1 ? "Не правильный ввод" : $"{num} -> {SecondDigit(num)}");

int SecondDigit(int number)
{
    return number > 99 && number < 1000 ? (number % 100 / 10) : -1;
}
