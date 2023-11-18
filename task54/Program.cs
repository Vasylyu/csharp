/*
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.

Исходная матрица:
9   1   7   
1   2   3   
4   5   6   

Матрица с упорядоченными по убыванию строками:
9   7   1   
3   2   1   
6   5   4

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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] SortRowsDescending(int[,] array)
{
    int j = 0;
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)               //checking all rows
    {
        for (j = 0; j < array.GetLength(1); j++)                //Starting from each element in column
        {
            int max = j;
            for (k = j; k < array.GetLength(1); k++)            // checking if any number is greater than in j-position
            {
                if (array[i, max] < array[i, k])                         // if new max if found remeber its position                                          
                {
                    max = k;
                }
            }
            var temp = array[i, max];                      // Swap max and current j-position
            array[i, max] = array[i, j];
            array[i, j] = temp;
        }
    }
    return array;
}

int userArrayRow = TakeEnterNumber("Введите количестов строк:");
int userArrayColumn = TakeEnterNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnterNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnterNumber("Введите конец диапозона:");

int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);
int[,] userRan = SortRowsDescending(user2DArray);
System.Console.WriteLine();
Print2DArray(userRan);






