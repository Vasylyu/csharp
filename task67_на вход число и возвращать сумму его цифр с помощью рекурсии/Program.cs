/*
Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр.
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int intN(int number)
{

    if (number % 10 > 0)
        return number % 10 + intN(number / 10);
        else
        return 0;
}

int result = intN(number);
System.Console.WriteLine($"сумма равна {result}");