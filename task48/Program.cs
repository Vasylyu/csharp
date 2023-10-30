/*
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] GetRandom2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
            arr[i, j] = (i + j);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
/*string[,] GetIndex2DArray(int row, int column)
{
    string[,] array = new string[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = ($"{i} + {j} = {i + j}");
        }
    }
    return array;
}
*/
int[,] array2D = new int[3, 4];

GetRandom2dArray(array2D);

Print2DArray(array2D);
