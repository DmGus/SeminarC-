// Программа, которая принимает на ввод число,
// и раскладывает его на простые множители;

// Алгоритм с записью всех простых множителей составного числа в массив
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool simple = true;
int index = 2;
int indexarray = 0;
int numtemp = num;
int[] digitarray = new int[100];

while (index <= (num / 2))
{
    if (numtemp % index == 0)
    {
        digitarray[indexarray] = index;
        indexarray++;
        simple = false;
        numtemp = numtemp / index;
        index = index - 1;
    }
    index++;
}

if (simple) Console.WriteLine($"Число {num} является простым");
else
{
    Console.Write($"Число {num} является составным = ");
    index = 0;
    while (index < indexarray - 1)
    {
        Console.Write($"{digitarray[index]} * ");
        index++;
    }
    Console.Write($"{digitarray[index]}");
}


// // Алгоритм без массива
// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Число {num} = ");

// while (num > 1)
// {
//     int count = 2;
//     while (num % count != 0) count++;
//     num = num / count;
//     Console.Write($"{count}*");
// }
// Console.Write("\b \b");