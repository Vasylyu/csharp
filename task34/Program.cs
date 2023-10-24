/*
Напишите программу, которая подсчитывает количество четных элементов в массиве 
целых положительных трехзначных чисел и выводит результат на экран.

Программа должна иметь метод CountEvenElements, который принимает массив
 целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

При выводе элементы массива должны быть разделены символом табуляции "\t".

Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.

Аргументы, передаваемые в метод/функцию:

'124, 378, 593, 821, 456'
На выходе:


Массив:
124     378     593     821     456 
Количество четных элементов: 3
*/


int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        //array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{

    foreach (int number in arr)
    {
        Console.Write($"{number}\t");
    }
    Console.WriteLine();
}


void CountPos(int[] arr)
{
    int evenCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) evenCount++;
    }
    System.Console.WriteLine(evenCount);
}

int[] array = GetRnd(10);
PrintArray(array);
System.Console.WriteLine();
CountPos(array);
int[] arrayTwo = { 4, 5, 7 };
PrintArray(arrayTwo);