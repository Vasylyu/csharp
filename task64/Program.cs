/*
Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void intN(int number, int current)
{
    if (number >= 1)
    {
        System.Console.Write(" {0} ", number);
        number--;
        intN(number, current);
    }
    else
        return;
}

intN(number, 1);