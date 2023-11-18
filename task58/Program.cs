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
/*
void GetRandom2dArrayA(int[,] arr1)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
}

void GetRandom2dArrayB(int[,] arr2)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
}


int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
    {
        int[,] multiplicative = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < multiplicative.GetLength(0); i++)
        {
            for (int j = 0; j < multiplicative.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    multiplicative[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        return multiplicative;
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
int[,] array3D = new int[3, 4];
GetRandom2dArrayA(array2D);
Print2DArrayA(array2D);
System.Console.WriteLine();
GetRandom2dArrayB(array3D);
Print2DArrayB(array3D);
int[,] twomatrix = MatrixMultiplication(array2D, array3D);
Print2DArrayA(twomatrix);
*/




void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("It is impossible to multiply.");
    }
    else
    {
        int[,] multiplicative = MatrixMultiplication(matrixA, matrixB);
        PrintMatrix(multiplicative);
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplicative = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < multiplicative.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicative.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                multiplicative[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return multiplicative;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3,4];
int[,] matrixB = new int[3,4];
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

Console.WriteLine("\nMatrix B:");
PrintMatrix(matrixB);

Console.WriteLine("\nMultiplication result:");
MultiplyIfPossible(matrix, matrixB);
    
