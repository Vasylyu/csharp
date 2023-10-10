/*
 Напишите программу, которая выводит третью цифру заданного числа 
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//int number = new Random().Next(1, 100000);

System.Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int zero = number;
int first = number % 10 % 10;
int second = number / 10 % 10;
int three = number / 100 % 10;


if (zero < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}

else if (first < 1000)
{
    System.Console.WriteLine($" {first} это третья цифра");

}
else if (second < 10000 || second > 1000) 
{
    System.Console.WriteLine($" {second} это три из четырех");
}

else if (second < 10000) 
{
    System.Console.WriteLine($" {second} это три из четырех");
}

else if (three < 100000)

{
    System.Console.WriteLine($" {three} это три из 5");
}



