// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int arraynummin = -99, arraynummax = 99, arraysize = 4;

int[] arr = CreateArrayRndInt(arraysize, arraynummin, arraynummax);
PrintArray(arr);
int result = SumNoevenPos(arr);
Console.WriteLine($" -> {result}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + ",");
        else System.Console.Write(array[i]);
    }
    System.Console.Write("]");
}

int SumNoevenPos(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        count = count + array[i];
        
    }
    return count;
}

