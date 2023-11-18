/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку
 с наименьшей суммой элементов.

Исходная матрица:
9   1   7   
1   2   3   
4   5   6   

Сумма наименьшей строки (строка 2): 6
Сумма элементов в строке 2: 6
*/

void GetRandom2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
}

void Print2DArray(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.White;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int SumOfRow(int[,] array, int row)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[row, j];
    }
    return sum;
}

int[] MinimumSumRow(int[,] array)
{
    int[] RowNumberAndSum = new int[2];
    RowNumberAndSum[1] = SumOfRow(array, RowNumberAndSum[0]);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (RowNumberAndSum[1] > SumOfRow(array, i))
        {
            RowNumberAndSum[0] = i;
            RowNumberAndSum[1] = SumOfRow(array, RowNumberAndSum[0]);
        }
    }
    return RowNumberAndSum;
}


int[,] array2D = new int[3, 4];
GetRandom2dArray(array2D);
Print2DArray(array2D);
int[] minSumRow = MinimumSumRow(array2D);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");


