﻿/*
Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7
*/

int TakeEnterNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + arr.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"[" + i + "]\t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}



(int, int) FindMinIndex(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}


int[,] DeletMinColumn(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
        {
            row = -1;
            continue;
        }
        int y = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == column) continue;

            result[x, y] = array[i, j];
            y++;
        }
        x++;
    }

    return result;
}
int userArrayRow = TakeEnterNumber("Введите количестов строк: ");
int userArrayColumn = TakeEnterNumber("Введите количестов столбцов: ");
int userArrayStart = TakeEnterNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnterNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
(int minRow, int minColumn) = FindMinIndex(user2DArray);

int[,] newArray = DeletMinColumn(user2DArray, minRow, minColumn);
System.Console.WriteLine();
Print2DArray(newArray);