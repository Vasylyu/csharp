/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 
1) менять числа местами в исходном массиве; 
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
*/

Console.Clear();

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 8);
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
    System.Console.WriteLine("]");
}

int[] ArrayRevers(int[] array)
{

    int a = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        a = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = a;
    }
    return array;
}

System.Console.WriteLine("Введите размер массива: ");
int userarraySize = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(userarraySize);
PrintArray(userArray);
int[] userReversArray = ArrayRevers(userArray);
PrintArray(userReversArray);