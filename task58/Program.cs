/*
Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.

Исходная матрица A:
1   2   
3   4   

Matrix B:
5   6   
7   8   

Multiplication result:
19  22  
43  50
*/


void GetRandom2dArrayA(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
}

void GetRandom2dArrayB(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
}


    void Print2DArrayA(int[,] arr)
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

void Print2DArrayB(int[,] arr)
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
void Print2DArrayC(int[,] arr)
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
void MultArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                if (arrayOne.GetLength(0) == arrayTwo.GetLength(0) && arrayOne.GetLength(1) == arrayTwo.GetLength(1))
                {
                    result[i, j] += arrayOne[i, k] * arrayTwo[k, j];
                }
                else Console.WriteLine("Массивы нельзя перемножить");
            }
        }
    }
    Print2DArrayC(result);
}


int[,] arrayOne = new int[2, 2];
int[,] arrayTwo = new int[2, 2];
System.Console.WriteLine();
GetRandom2dArrayA(arrayOne);
Print2DArrayA(arrayOne);
System.Console.WriteLine();
GetRandom2dArrayB(arrayTwo);
Print2DArrayB(arrayTwo);
System.Console.WriteLine();

MultArray(arrayOne, arrayTwo);

