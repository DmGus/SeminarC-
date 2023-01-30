// Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int mUser = InsertDigit("Введите число m: ");
int nUser = InsertDigit("Введите число n: ");
int akkerman = AkkermanFunc(mUser, nUser);
Console.WriteLine($"A({mUser},{nUser}) = {akkerman}");

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.Write(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if ((m != 0) && (n == 0)) return AkkermanFunc(m - 1, 1);
        else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
}