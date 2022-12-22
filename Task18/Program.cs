// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).




Console.WriteLine("Введите номер четверти координатной плоскости: ");
Console.Write("Четверть (1-4) = ");
int num = Convert.ToInt32(Console.ReadLine());

string result = Range(num);
Console.WriteLine(result);

string Range(int qu)
{
if (qu == 1) return "x > 0, y > 0";
if (qu == 2) return "x < 0, y > 0";
if (qu == 3) return "x < 0, y < 0";
if (qu == 4) return "x > 0, y < 0";
return "Не корректный ввод";
}