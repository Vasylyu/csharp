/*
Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
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
        if (arrSecond[i] == numb)
        result = true;

    }
    return result;
}

int[] userArray = RandomArray(8);
System.Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int numb = Convert.ToInt32(Console.ReadLine());
PrintArray(userArray);
System.Console.WriteLine(FindNomber(userArray, numb));
bool result2 = FindNomber(userArray,n);
System.Console.WriteLine((result2)?$"Число {n} в массиве есть":"Число {n} в массиве нет");