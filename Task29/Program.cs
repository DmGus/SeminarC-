// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreatRandomArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintNiceArray(int[] prarr)
{
    for (int i = 0; i < prarr.Length - 1; i++)
    {
        Console.Write($"{prarr[i]}, ");
    }
    Console.Write($"{prarr[prarr.Length-1]}");
}

int[] ar = CreatRandomArray(8);
PrintNiceArray(ar);
Console.Write(" -> [");
PrintNiceArray(ar);
Console.Write("]");
