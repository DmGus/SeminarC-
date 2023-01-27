// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array2D1 = CreateMatrixRndInt(rows: 2, columns: 2, min: 1, max: 5);
int[,] array2D2 = CreateMatrixRndInt(rows: 2, columns: 2, min: 1, max: 5);

Console.WriteLine("Даны 2 матрицы:");
PrintIntMatrix(array2D1);
Console.WriteLine("*");
PrintIntMatrix(array2D2);
Console.WriteLine();
if (array2D1.GetLength(0) == array2D2.GetLength(1))
{
int[,] Array2DMult = MatrixMultiplication (array2D1,array2D2);
Console.WriteLine("Результирующая матрица будет:");
PrintIntMatrix(Array2DMult);
}
else Console.WriteLine("Матрицы нельзя перемножить");

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


int[,] MatrixMultiplication(int[,]matrix1,int[,]matrix2)
{
    int[,]result = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i,j] = result[i,j]+matrix1[i,k]*matrix2[k,j];                
            }            
        }
    }
    return result;
}


// matrix
// new     m1  *  m2

// Cycle
// i,j   i       j          k 
// 1,1 = 1 row * 1 col =  new[i,j] += m1[i,k]*m2[k,j]   
// 1,2 = 1 row * 2 col =  new[i,j] += m1[i,k]*m2[k,j]
// 1,3 = 1 row * 3 col =

// 2,1 = 2 row * 1 col =
// 2,2 = 2 row * 2 col =
// 2,3 = 2 row * 3 col =

// 3,1 = 3 row * 1 col =
// 3,2 = 3 row * 2 col =
// 3,3 = 3 row * 3 col =


// [m00 m01]   [n00 n01 n02]    =   [m00*n00+m01*n10, m00*n01+m01*n11]
// [m10 m11]   [n10 n11 n12]        [m10*n00+m11*n10, m10*n01+m11*n11]
// [m20 m21]                        [m]
