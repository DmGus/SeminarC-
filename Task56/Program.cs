// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrixRndInt(rows: 4, columns: 4, min: 1, max: 9);
PrintIntMatrix(array2D);
Console.WriteLine();
Console.WriteLine("Сумма элементов в каждой строке:");
int[] sumrows=GetRowsSumElements(array2D);
PrintArray(sumrows);
ShowIndexMinElement("номер строки с наименьшей суммой элементов: ",sumrows, " строка");

// Create int Random Matrix from min to max
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

// Print int Matrix in Console
void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine(" ]");
    }
}

int[] GetRowsSumElements(int[,] matrix)
{
    int [] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           result[i]+=matrix[i,j]; 
        }
    }
    return result;
}

// Print int Array
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + ",");
        else System.Console.Write(array[i]);
    }
    System.Console.WriteLine("]");
}

// Show start message + index of Array's minimum element + end message
void ShowIndexMinElement(string startmessage, int[] array, string endmessage)
{
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<array[indexMin]) indexMin=i;
    }
    System.Console.Write(startmessage+(indexMin+1)+endmessage);
}