﻿// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array2D = CreatSpiralMatrix(4);
PrintIntMatrix(array2D);

// Creat Spiral Matrix 
// don't work with size=2;
int[,] CreatSpiralMatrix(int size)
{
    int[,] result = new int[size, size];
    int row = 0, column = 0;
    for (int i = 0; i < (size) * (size); i++)
    {
        result[row, column] = i + 1;
        if (row == 0 && column < size - 1) column++;
        else if (column == size - 1 && row < size - 1) row++;
        else if (row == size - 1 && column > 0) column--;
        else if (column == 0 && row > 1) row--;
        else if (result[row, column + 1] == 0 && result[row-1, column]!= 0) column++;
        else if (result[row + 1, column] == 0) row++;
        else if (result[row, column - 1] == 0) column--;
        else if (result[row - 1, column] == 0) row--;
    }
    return result;
}

// Print int Matrix in Console with 0 if <10
void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"0{matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("");
    }
}