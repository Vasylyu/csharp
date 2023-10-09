/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трехзначенное число");
if (number < 100 || number >= 1000)
{
    System.Console.WriteLine("вы ввели не трехзначенное число, повторите ввод");

    return;
}
System.Console.WriteLine($"Введенное число {number} ");

int two = number / 10 % 10;
System.Console.WriteLine($"вторая цифра {two} ");
