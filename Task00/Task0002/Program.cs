// CreatRandomArrayWithoutRepeat and print random int Array without repeat;


int[] arr = CreatRandomArrayWithoutRepeat(5, 1, 6);
PrintArray(arr);

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

// CreatRandomArrayWithoutRepeat and print random int Array without repeat;
int[] CreatRandomArrayWithoutRepeat(int size, int min, int max)
{
    if (max<size) max=min+size;
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
    return randomArray;
}
