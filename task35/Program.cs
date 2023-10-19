/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов.
 В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int[] GenerateArray()
{
    int[] array = new int[123];
    Random random = new Random();
    for (int i = 0; i < 123; i++)
    {
        array[i] = random.Next(0, 1000);
    }
    return array;
}
int FindNumb(int[] arrayfr)
{
    int count = 0;
    for (int i = 0; i < arrayfr.Length; i++)
    {
        if (arrayfr[i] >= 10 && arrayfr[i] <= 99)
            count++;
    }
    return count;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");

    }
    System.Console.Write("]");
}
int[] userArray = GenerateArray();
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine(FindNumb(userArray));