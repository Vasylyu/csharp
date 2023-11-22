/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

System.Console.WriteLine("Введите число 1: ");
int first = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int last = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int first, int last)
{
    if (first == 0) return (last * (last + 1)) / 2;            
            else if (last == 0) return (first * (first + 1)) / 2;       
            else if (first == last) return first;          
    else if (first < last) 
    return last + SumNumbers(first, last - 1);
    else return last + SumNumbers(first, last + 1);
}

Console.WriteLine($" Сумма = {SumNumbers(first, last)}");

