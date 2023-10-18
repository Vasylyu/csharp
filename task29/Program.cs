/*
Напишите программу, которая берет массив у пользователя, его размери выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*Console.Clear();

System.Console.Write("Задай диапозон массива от: ");
int[] userStart = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задай диапозон массива до: ");
int[] userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задай разmер массива: ");
int[] userSize = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int star, int stop, int size);
{
    int[] ray = new int[size];
    for (int i = 0; i < size; i++)
    {
        ray[i] = new Random().Next(start, stop + 1);
    }
    return ray;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i<arr.length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.length -1)
        System.Console.WriteLine(", ");
    }
    System.Console.Write("]");
}

int[] userArray = GetArray(userStart, userEnd, userSize);
PrintArray(userArray);
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
        System.Console.Write(", ");//[5, 7, 1, 4]
    }
    System.Console.Write("]");
}

System.Console.WriteLine("Задай диапазон массива от:");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай диапазон массива до:");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай размер массива:");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userEnd, userSize);
PrintArray(userArray);