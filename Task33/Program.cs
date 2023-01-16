// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + ",");
        else System.Console.Write(array[i]);
    }
    System.Console.WriteLine("]");
}

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

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);
System.Console.WriteLine("Введите искомое число: ");
int numb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindNumber(arr, numb) ? "да" : "нет");

