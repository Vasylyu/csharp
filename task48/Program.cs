/*
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
string[,] GetIndex2DArray(int row, int column)
{
    string[,] array = new string[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] =($"{i} + {j} = {i + j}");
        }
    }
    return array;
}