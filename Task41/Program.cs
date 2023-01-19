// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] arr = GetUserNumbers();
PrintArray(arr);
int countpos = CountArrayPositiveNumbers(arr);
Console.WriteLine($"Вы ввели {countpos} чисел больше 0");

//METHODS
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

// Count Positive Numbers from Array
int CountArrayPositiveNumbers(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count=count+1;
    }
    return count;
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