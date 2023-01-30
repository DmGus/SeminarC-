// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Enter natural number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter natural number: ");
int b = Convert.ToInt32(Console.ReadLine());

int pow = PowerNumbers(a, Math.Abs(b));
double powd = Math.Round((double) 1/pow,3);
Console.WriteLine(b>0 ? $"Power = {pow}" : $"Power = 1/{pow} = {powd}");


int PowerNumbers(int num, int power)
{
    if (power==0) return 1;
    return PowerNumbers(num,power-1)*num;
}