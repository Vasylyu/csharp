/*
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int TakeEnterNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double GetRandom2dArray(int deviation, int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round((new Random().NextDouble() * (2 * deviation * 10) - deviation), 1);
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
int userArrayDeviation = TakeEnterNumber("Введите диапозон");

int[,] user2DArray = GetRandom2DArray(userArrayDeviation, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);