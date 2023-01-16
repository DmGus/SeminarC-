// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
    System.Console.WriteLine("]");
}

int[] NewArray(int[] array)
{
    int size = array.Length/2;
    if(array.Length % 2 != 0) size = size + 1;
    int[] arr = new int[size];
    for (int i = 0; i < size ; i++)
    {
        arr[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 != 0) arr[size - 1] = array[array.Length/2];
    return arr;

}


int[] arr = CreateArrayRndInt(7, 0, 10);
PrintArray(arr);
PrintArray(NewArray(arr));

// РЕШЕНИЕ 2
// int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
// {
//     int[] resArray = new int[arraySize];
//     Random rnd = new Random();
//     for (int i = 0; i < resArray.Length; i++)
//     {
//         resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
//     }
//     return resArray;
// }


// string ArrayToString(int[] array)//Метод преобразования массива в строку
// {
//     string result = "[";
//     for (int i = 0; i < array.Length; i++)
//     {
//         result = result + $" {array[i]}";
//         result = i < (array.Length - 1) ? result = result + "," : result;//для корректности вывода запятых
//     }
//     return result + " ]";
// }
