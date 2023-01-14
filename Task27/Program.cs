// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InsertNumber()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine());
}

int DigitsSum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    if (sum < 0) sum = -sum;
    return sum;
}

int number = InsertNumber();
int digitssum = DigitsSum(number);
Console.WriteLine($"{number} -> {digitssum}");