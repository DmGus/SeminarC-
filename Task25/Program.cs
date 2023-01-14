// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InsertNumber()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine());
}

int NumberDegree(int num, int deg)
{
    int numdeg = 1;
    for (int i = 0; i < deg; i++)
    {
        numdeg = numdeg * num;
    }
    return numdeg;
}

int a = InsertNumber();
int b = InsertNumber();

if (b >= 0)
{
    int number = NumberDegree(a, b);
    Console.WriteLine($"Число {a} в {b} степени = {number}");
}
else
{
    b = -b;
    int number = NumberDegree(a, b);
    Console.WriteLine(a >= 0 ? $"Число {a} в -{b} степени = 1/{number}" : $"Число {a} в -{b} степени = -1/{-number}");
}