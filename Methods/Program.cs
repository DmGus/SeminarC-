// Methods

//Get User Number
int InsertDigit(string text) 
{
 System.Console.WriteLine(text);
 int result = Convert.ToInt32(Console.ReadLine());
 return result;
}

// Create Random int Array
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

// Print int Array
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

// Get User Numers
int[] GetUserNumbers()
{
    Console.Write("Введите числа через запятую: ");
    string str = Console.ReadLine();
    string[] strArr = str.Split(',');
    int[] result = new int [strArr.Length];
    for (int i = 0; i < strArr.Length; i++)
    {
        result[i]=Convert.ToInt32(strArr[i]);
    }
    return result;
}


// DOUBLE

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
