/*
 Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.

Например, изначально массив                
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
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


int[,] ModifyEvenIndexSquare(int[,] array)
{
    int[,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) result[i, j] = array[i, j] * array[i,j];
        }
    }
    return result;
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

int[,] userNewArray = ModifyEvenIndexSquare(user2DArray);


System.Console.WriteLine();
Print2DArray(userNewArray);