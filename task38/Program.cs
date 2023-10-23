/*
Напишите программу для работы с массивом вещественных чисел.

Реализуйте класс ArrayOperations, который содержит следующие статические методы:

FindMax(double[] array): Метод принимает на вход массив вещественных чисел array 
и возвращает максимальное число из массива.

FindMin(double[] array): Метод принимает на вход массив вещественных чисел array
 и возвращает минимальное число из массива.

CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array 
и возвращает разницу между максимальным и минимальным числами в массиве.

PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array
 и выводит его элементы с двумя знаками после запятой через табуляцию.

Аргументы, передаваемые в метод/функцию:

'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:


Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/

int Prompt(string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

double[] GenerateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (maxValue + 0.01 - minValue) + minValue, 2);
    }
    return array;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double result = FindMax(array) - FindMin(array);
    return result;
}

void PrintArray(double[] arrayOne)
{
    System.Console.WriteLine("Массив:");
    System.Console.Write("[");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальный элемент: {FindMin(arrayOne)}");
    System.Console.WriteLine($"Максимальный элемент: {FindMax(arrayOne)}");
    System.Console.WriteLine($"Разность между максимальным и минимальным элементами = {CalcDifferenceBetweenMaxMin(arrayOne)}");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
double[] array = GenerateArray(length, min, max);
PrintArray(array);