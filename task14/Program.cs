/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно,и одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

System.Console.WriteLine("задай число");

int number = Convert.ToInt32(Console.ReadLine());


if (number % 7 == 0 && number % 23 == 0)

    System.Console.WriteLine("да");
else
{
    System.Console.WriteLine("no");
}