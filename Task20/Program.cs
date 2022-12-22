// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("введите координаты");

Console.WriteLine("введите х1");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите у1");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите х2");
double x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите у2");
double y2=Convert.ToDouble(Console.ReadLine());

double dist=Math.Round(Distance(x1,y1,x2,y2),2,MidpointRounding.ToZero);
Console.WriteLine($"расстояние между точками -> {dist}");
double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}
