// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int number = NumberInput("Please, input your number: ");
int[]arr = FibArray(number);
PrintArray(arr);

int NumberInput(string text) // Method fot Number input
{
    Console.Write(text);
    int numberinput = Convert.ToInt32(Console.ReadLine());
    return numberinput;
}

int[]FibArray(int count)
{
    int[] result = new int[count];
    result[1] = 1;
    for (int i = 2; i < count; i++) 
    {
        result[i] = result[i-1]+result[i-2];
    }
    return result;
}

// Печать массива int
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
