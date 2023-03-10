// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(number);
System.Console.WriteLine($"Sum = {sum}");

int SumDigits(int num)
{
    if (num==0) return 0;
    return SumDigits(num/10)+num%10;
}

// 453 - 45 - 0+3
// 45 - 4 - 3+5
// 4 - 0 - 8+4
