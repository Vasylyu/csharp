/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int[] GenerateArray()
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(0, 10);
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
int[] ProductArray(int[] parr);
{
    int[] result = new int[parrLength / 2];
    int sum = 0;
    int[] result = new int[parr.Length / 2];
    if (parr.Length % 2 ==1) 
    {
        middle = parr[parr.Lenght/2 +1];
    }
    for (int i = 0; i < parr.Length / 2; i++)
    {
        sum = parr[i] * parr[parr.Length - 1 - i];
        result[i] = sum;
    }
    return result;
}

int[] userArray = GenerateArray();
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);