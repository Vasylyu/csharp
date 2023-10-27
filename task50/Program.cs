/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 и 2 -> 2
1 и 7 -> такого числа в массиве нет
*/

int TakeEnterNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int row, int column, int k)
{
    int[,] array = new int[row, column];
    int num = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = num;
            num = num + k;
        }
    }
    return array;
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

int userArrayRow = TakeEnterNumber("Введите количество строк");
int userArrayColumn = TakeEnterNumber("Введите количество столбцов");
int numberK = TakeEnterNumber("Увеличение? ");
int[,] user2DArray = GetRandom2DArray(userArrayRow, userArrayColumn, numberK);
Print2DArray(user2DArray);
int PositionX = TakeEnterNumber("На какой строке");
int PositionY = TakeEnterNumber("На каком столбце");


void FindElementInArray(int[,] array, int x, int y)
{
    if (x < array.GetLength(0) && y < array.GetLength(1))
System.Console.WriteLine($"Такое число в массиве есть, это число {array[x, y]}");
else
System.Console.WriteLine("Такого числа в массиве нет");
}

FindElementInArray(user2DArray,PositionX, PositionY);




