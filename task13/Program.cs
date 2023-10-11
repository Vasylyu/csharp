/*
 Напишите программу, которая выводит третью цифру заданного числа 
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int first = number;
int second = number;
int three = number;
int four = number;
int fifth = number;

if (number < 99)
{
    Console.WriteLine("нету третьего числа");
}

else if (first < 1000)
{
    first = number % 10 % 10;
    System.Console.WriteLine($" {first} это третье число");
}

else if (second < 10000)
{
    second = number / 10 % 10;
    System.Console.WriteLine($" {second} это третье число");
}

else if (three < 100000)

{
    three = number / 100 % 10;
    System.Console.WriteLine($" {three} это третье число");
}

else if (four < 1000000)

{
    four = number / 1000 % 10;
    System.Console.WriteLine($" {four} это третье число");
}

else if (fifth < 10000000)

{
    fifth = number / 10000 % 10;
    System.Console.WriteLine($" {fifth} это третье число");
}

