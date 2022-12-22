// 22

void Numb(int n1)
{
    int counter = 1;
    while(counter <= n1)
    {
        Console.WriteLine($"{counter, 3} {counter * counter, 3}");
        counter++;
    }
}

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 1)
{
    System.Console.WriteLine("Введите положительное, целое число");
    number = Convert.ToInt32(Console.ReadLine());
}

Numb(number);

// Console.Write("Введите число: ");

// int num = Convert.ToInt32(Console.ReadLine());
// SqNum(num);

// void SqNum (int number)
// {
//     int index=1;
//     while (index<=number)
//     {
//         Console.WriteLine ($"{index, 3} -> {index*index, 3}");
//         index++;
//     }

// }
