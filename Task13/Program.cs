// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, 
// остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число и нажмите Enter: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdDigit(num) == -1 ? $"{num} -> третьей цифры нет" : $"{num} -> {ThirdDigit(MakeThreeDigits(num))}");

int ThirdDigit(int number)
{
    return number > 99 ? (number % 10) : -1;
}

int MakeThreeDigits(int numb)
{
    while (numb>999) numb=numb/10;
    return numb;
}
