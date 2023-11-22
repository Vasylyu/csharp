/*
Заполните спирально массив 4 на 4.
*/

void GetRandom2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, +1);
        }
    }
}
void Print2DArray(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {

            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


void intN(int arr, int current = 1)
{
    if (arr >= current)
    {
        System.Console.Write(current + " ");
        intN(arr, current + 1);
    }
    else
        return;
}


/*
    for (int j = 0; j < arr.GetLength(1); j++)
    {

    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {

    }
    for (int j = 0; j < arr.GetLength(1); j++)
    {

    }
}

*/


int[,] arr = new int[4, 4];
//int[,] arrayOne = Spirale(arrayTwo);
GetRandom2dArray(arr);
Print2DArray(arr);
System.Console.WriteLine();
intN(arr);

