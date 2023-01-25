// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] test = CreateMatrixRndInt(3, 4, 0, 9);
PrintIntMatrix(test);
int[] positionelement = GetElementPosition("Введите строку и столбец элемента: ");

if (positionelement.Length == 2) PrintElementValue(test, positionelement[0], positionelement[1]);
else Console.WriteLine("не корректный ввод");



// Methods

// Create Matrix with Random Numbers from min to max
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Print int Matrix
void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("   ]");
    }
}

// Get User Numers
int[] GetElementPosition(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    string[] strArr = str.Split(',');
    int[] result = new int[strArr.Length];
    for (int i = 0; i < strArr.Length; i++)
    {
        result[i] = Convert.ToInt32(strArr[i]);
    }
    return result;
}

void PrintElementValue(int[,] matrix, int row, int column)
{
    Console.WriteLine(row >= 0 && column >= 0 && matrix.GetLength(0) > row && matrix.GetLength(1) > column
    ? $"{row}, {column} -> {matrix[row,column]}"
    : $"{row}, {column} -> такого элемента в массиве нет");    
}