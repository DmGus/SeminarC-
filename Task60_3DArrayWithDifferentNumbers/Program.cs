// *Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] arr3D = CreateArray3DRndInt(2,2,2,10,99);
PrintIntArray3D (arr3D);

// Create int Random Matrix from min to max
int[,,] CreateArray3DRndInt(int rows, int columns, int depth, int min, int max)
{
    if (rows*columns*depth>max-min) max=rows*columns*depth+min;
    int size = rows*columns*depth;
    Random rnd = new Random();
    int[] randomArray = new int[size];
    for (int i = 0; i < randomArray.Length; i++)
    {
        bool repeat=true;
        while (repeat)
        {
            repeat=false;
            randomArray[i] = rnd.Next(min, max + 1);
            for (int j = 0; j < i; j++)
            {
                if (randomArray[i] == randomArray[j] && i!=j) 
                {
                    randomArray[i] = rnd.Next(min, max + 1);
                    repeat=true;
                }
            }
        }
    }
    int count=0;
    int[,,] array3D = new int[rows, columns,depth];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
            array3D[i, j, k] = randomArray[count];
            count++;
            }            
        }
    }
    return array3D;
}

// Print int array 3D in Console
void PrintIntArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int n = 0; n < array3D.GetLength(2); n++)
            {
            Console.Write($"{array3D[i, j, n],1} ({i},{j},{n}) ");              
            }            
        }
        Console.WriteLine(" ");
    }
}

