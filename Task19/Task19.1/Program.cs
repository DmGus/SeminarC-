// Задача 19.1
// Напишите программу, которая 
// 1) принимает на вход любое положительное целое число и 
// 2) проверяет, является ли оно палиндромом.
// 3) Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
    Console.WriteLine(Polindrom(num)
    ? $"{num} -> да" : $"{num} -> нет");
else Console.Write("Не корректный ввод");

// ОПИСАНИЕ МЕТОДОВ

// Полиндром
bool Polindrom(int number)
{
    if (ReversDigits(number) == number) return true;
    return false;
}

// Разворот числа
int ReversDigits(int numrev)
{
    int countd = 1;
    int temp = 0;
    int quantityDigits = CountDigits(numrev);
    while (countd <= quantityDigits / 2)
    {
        int firstdigit = numrev / Convert.ToInt32(Math.Pow(10, quantityDigits - countd)) % 10;
        int lastdigit = numrev % Convert.ToInt32(Math.Pow(10, countd)) / Convert.ToInt32(Math.Pow(10, countd - 1));
        temp = temp + lastdigit * Convert.ToInt32(Math.Pow(10, quantityDigits - countd))
        + firstdigit * Convert.ToInt32(Math.Pow(10, countd - 1));
        countd++;
    }
    if (quantityDigits % 2 != 0)
    {
        int midledigit = numrev / Convert.ToInt32(Math.Pow(10, quantityDigits - countd)) % 10;
        temp = temp + midledigit * Convert.ToInt32(Math.Pow(10, countd - 1));        
    }
    return temp;
}

// Количество цифр в числе
int CountDigits(int numd)
{
    int indexd = 0;
    while (numd > 0)
    {
        numd = numd / 10;
        indexd++;
    }
    return indexd;
}