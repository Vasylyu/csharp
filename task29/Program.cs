/*
Напишите программу, которая берет массив у пользователя, его размер и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/



int[] GetArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end+1);
    }
    return array;
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

System.Console.WriteLine("Задай диапазон массива от:");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай диапазон массива до:");
int userStop = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай размер массива:");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userStop, userSize);
PrintArray(userArray);
