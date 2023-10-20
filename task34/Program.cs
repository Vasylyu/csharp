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
/*
System.Console.WriteLine("Введите число: ");
int[] GenerateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] % 2;
    }
    return array;
}


int[] GenerateArray()

{
    int[] array = new int[size];

    for (int i = 0; i <= size; i++)
    {
        if (array[i] % 2 == 0);
    }
    return array;
    
}


//for (int i = 2; i <= number; i+=2)

   // System.Console.Write(i + "\t");


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}");
    }

}
int userStart = Convert.ToInt32(Console.ReadLine());
int[] userArray = GenerateArray(userStart);
PrintArray(userArray);
System.Console.WriteLine();
*/
int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}");
    }

}

bool FindNomber(int[] arrSecond, int numb)
{
    bool result = false;
    for (int i = 0; i < arrSecond.Length; i++)
    {
        if (arrSecond[i] == numb / 2) 
        result = true;


    }
    return result;
}

int[] userArray = RandomArray(8);
System.Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
PrintArray(userArray);
System.Console.WriteLine(FindNomber(userArray, numb));