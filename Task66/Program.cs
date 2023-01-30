// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int mUser = InsertDigit("Введите число M: ");
int nUser = InsertDigit("Введите число N: ");
int sumn = SumNumbers(nUser, mUser);
Console.WriteLine($"M = {mUser}; N = {nUser} -> {sumn}");

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.Write(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int SumNumbers(int n, int m)
{
    if (n == m) return m;
    if (n > m) return SumNumbers(n - 1, m) + n;
    else return SumNumbers(n + 1, m) + n;
}




//     if (n == m)
//     {
//         Console.Write($"{n} ");
//         return;
//     }
//     if (n > m)
//         IntegerNumbers(n - 1, m);
//     else
//         IntegerNumbers(n + 1, m);
//     Console.Write($"{n} ");
// }

