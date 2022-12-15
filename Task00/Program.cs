// Напишите программу, которая на вход
// 1. принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
// string str Console.ReadLine ()
Console.WriteLine ("Введите целое число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
// int number1 = int.Parse  (Console.ReadLine ());
int square = number*number;
Console.WriteLine ($"Квадрат числа {number} = {square}");
