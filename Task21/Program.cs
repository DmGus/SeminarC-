// Задача 21
// Напишите программу, которая 
// 1) принимает на вход координаты двух точек и 
// 2) находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек");

Console.Write("Введите х A: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите у A: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z A: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите х B: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввведите у B: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввведите z B: ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double dist = Math.Round(Distance3D(xa, ya, za, xb, yb, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками A ({xa}, {ya}, {za}) и B ({xb}, {yb}, {zb}) -> {dist}");

double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

