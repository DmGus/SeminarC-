// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//замена "," на "." в выдаче результата
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

// Переменные
int arraynummin = 0, arraynummax = 100, arraysize = 5, decimalplaces = 1;

// Алгоритм
double[] arr = CreateArrayRndDouble(arraysize, arraynummin, arraynummax, decimalplaces);
PrintArrayDouble(arr);
double result = MaxNumber(arr)-MinNumber(arr);
Console.WriteLine($" -> {result}");

// Методы

// Создание произвольного массива double, размером size, значения от min до max, decplaces - знаков после запятой .
double[] CreateArrayRndDouble(int size, int min, int max, int decplaces)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, decplaces);
    }
    return array;
}

// Печать массива double
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

// Нахождение минимального числа в массиве double
double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

// Нахождение максимального числа в массиве double
double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}