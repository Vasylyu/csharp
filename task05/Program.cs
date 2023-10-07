/*
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
*/

using System.Runtime.CompilerServices;

System.Console.WriteLine("Введите число");

int numberA = Convert.ToInt32(Console.ReadLine());

int start = numberA * - 1;

while (start <= numberA)
{
     Console.WriteLine(start);
     start = start + 1;
}

