// Задача 23
// 1) Напишите программу, которая принимает на вход число (N) и 
// 2) выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите положительное, целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 1)
{
    Console.Write("Введите положительное, целое число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"  {number} -> ");
Numb(number);

void Numb(int n1)
{
    int counter = 1;
    while(counter <= n1)
    {
        Console.WriteLine($"{counter, 3} | {counter * counter * counter}");
        counter++;
    }
}