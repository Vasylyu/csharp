/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве
 целых чисел и выводит результат на экран.
 
Программа должна иметь метод SumOddElements, который принимает массив целых чисел 
и возвращает сумму элементов с нечетными индексами в массиве.

Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

При выводе элементы массива должны быть разделены символом табуляции "\t".

Аргументы, передаваемые в метод/функцию:


'18, 76, 11'
На выходе:


18      76      11  
Сумма нечетных элементов: 76
*/
Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

int SumNegIdx(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

/*
void Main(string[] args)
{
int[] array;
if (args.Length == 0)
{
   
    array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
}
else

    string[] argStrings = args[0].Split(", ");
array = new int[argStrings.Length];
for (int i = 0; i < argStrings.Length; i++)
{
    if (int.TryParse(argStrings[i], out int number))
    {
        array[i] = number;
    }
    else
    {
        Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
        return;
    }
}
}
*/
PrintArray(arr);
int sumOdd = SumNegIdx(arr);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");


