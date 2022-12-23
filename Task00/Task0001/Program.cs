// Программа, которая принимает на ввод число,
// и раскладывает его на простые множители;

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


// Количество цифр в числе
// int CountDigits(int numd)
// {
//     int indexd=0;
//     while(numd>0) 
//     {
//     numd = numd/10;
//     indexd++;
//     }
// return indexd + 1;
// }