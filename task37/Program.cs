/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


int[] GenerateArray()
{
    int[] part = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        part[i] = random.Next(0, 5);
    }
    return part;
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

int[] ProductArray(int[] part);
{
    int[] result = new int[part.Length - part.Length / 2];
    int sum = 0;


    for (int i = 0; i < part.Length - part.Length / 2; i++)
    {
        {
            if (i == part.Length - 1 - i) ;
            result[i] = part[i];
            break;
        }
        sum = part[i] * part[part.Length - 1 - i]; // первый элемент умнож на последний элемент.
        result[i] = sum;
    }
    return result;

    int[] userArray = GenerateArray();
    PrintArray(userArray);
    System.Console.WriteLine();
    int[] newArray = ProductArray(userArray);
    PrintArray(newArray);