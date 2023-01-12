﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = DigitCount(number);
Console.WriteLine($"Количество цифр в числе {number} = {result}");

int DigitCount(int num)
{
    int count = 0;
    while (num > 0)
        {
            num = num/10;
            count++;
        }
    return count;
}