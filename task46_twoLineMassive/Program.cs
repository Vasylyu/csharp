/*
Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/
/*
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
int userArrayStart = TakeEnterNumber("Введите начало диапозона");
int userArrayEnd = TakeEnterNumber("Введите конец диапозона");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);

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

int[,] array2D = new int[3, 4];
GetRandom2dArray(array2D);
Print2DArray(array2D);