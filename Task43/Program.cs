// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Tuple
// Out

//замена "," на "." в выдаче результата
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

//BODY
// Input vars
double k1 = InsertDigit("Введите переменную k для первой прямой вида y = k*x + b: ");
double b1 = InsertDigit("Введите переменную b для первой прямой вида y = k*x + b: ");
double k2 = InsertDigit("Введите переменную k для второй прямой вида y = k*x + b: ");
double b2 = InsertDigit("Введите переменную b для второй прямой вида y = k*x + b: ");

// Tuple
var pointcoordinate = CrossLinesCoordinate(k1, b1, k2, b2);
Console.WriteLine($"Прямая y = {k1}*x + {b1} и прямая y = {k2}*x + {b2}" 
+ $" переcекаются в точке с координатами [{pointcoordinate.x}, {pointcoordinate.y}]");

// Out
CrossLinesCoordinate(k1, b1, k2, b2, out double pointcoordinatex, out double pointcoordinatey);
Console.WriteLine($"Прямая y = {k1}*x + {b1} и прямая y = {k2}*x + {b2}" 
+ $" переcекаются в точке с координатами [{pointcoordinatex}, {pointcoordinatey}]");

//METHODS
//Get User Number
double InsertDigit(string text)
{
    System.Console.Write(text);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

// Tuple
// Cross Lines Point
// (double x, double y) CrossLinesCoordinate(double lk1, double lb1, double lk2, double lb2)
// {
//     double resultX = Math.Round((lb2 - lb1) / (lk1 - lk2),2);
//     double resultY = Math.Round(lk1 * (lb2 - lb1) / (lk1 - lk2) + lb1,2);
//     return (resultX, resultY);
// }

// Out
void CrossLinesCoordinate(double lk1, double lb1, double lk2, double lb2, out double resultX, out double  resultY)
{
    resultX = Math.Round((lb2 - lb1) / (lk1 - lk2),2);
    resultY = Math.Round(lk1 * (lb2 - lb1) / (lk1 - lk2) + lb1,2);    
}