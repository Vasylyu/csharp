/*
 Пользователь вводит с клавиатуры M чисел. 
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");

    }
    System.Console.Write("]");
}

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int CountPositiv(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result ++;
    }
    return result;
}


int userSize = Prompt("задай размер массива ");
System.Console.WriteLine("Введите число: ");
int[] userArray = GetRandomArray(userSize);

PrintArray(userArray);

int count = CountPositiv(userArray);
System.Console.WriteLine();
System.Console.WriteLine($"Цифр > 0 в заданном массиве = {count}");