/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
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
int[,] CopyArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i,j] = array [i,j];
        }
    }
    return result;
}

int[,] ChangeRows(int[,] array)
{
    int temperary = 0;
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temperary = result[0, j];
        result[0, j] = result[array.GetLength(0)-1, j];
        result[array.GetLength(0)-1, j] = temperary;
    }
    return result;
}

int userArrayRow = TakeEnterNumber("Введите количестов строк:");
int userArrayColumn = TakeEnterNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnterNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnterNumber("Введите конец диапозона:");

int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
int[,] userArray = ChangeRows(user2DArray);
System.Console.WriteLine();
Print2DArray(userArray);