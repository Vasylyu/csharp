﻿/*
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
*/
System.Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void intN(int first, int last  )
{
    if (last >= first)
    {
        System.Console.Write(first + " ");
        intN(first +1, last);
    }
    else
        return;
}

intN(number1,number2);