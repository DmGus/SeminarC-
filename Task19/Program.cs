// Задача 19
// Напишите программу, которая 
// 1) принимает на вход пятизначное число и 
// 2) проверяет, является ли оно палиндромом.
// 3) Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 99999)
    Console.WriteLine(Polindrom(num)
    ? $"{num} -> да" : $"{num} -> нет");
else Console.Write("Введенное число не пятизначное");

bool Polindrom(int number)
{
    if (number / 10000 == number % 10 &&
    number / 1000 % 10 == number % 100 / 10) return true;
    return false;
}


// * С любым числом, через массив

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Polindrom(num)
// ? $"{num} -> да" : $"{num} -> нет");

// bool Polindrom(int number)
// {
//     if(number == DigitsRevers(number)) return true;
//     else return false;
// }

// int DigitsRevers(int numrev)
// {
//     int index = 0;
//     int[] digitsarray = new int[100];
//     while (numrev > 0)
//     {
//         digitsarray[index] = numrev % 10;
//         numrev = numrev / 10;
//         index++;
//     }
//     int index2 = 0;
//     int numtemp = 0;
//     while (index2<index)
//     {
//     numtemp = numtemp + digitsarray[index2] * Convert.ToInt32(Math.Pow(10, index-index2-1));
//     index2++;
//     }
// return numtemp;
// }