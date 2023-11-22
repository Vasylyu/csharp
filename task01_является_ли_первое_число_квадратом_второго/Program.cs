/* 
Напишите программу, которая принимает два числа и проверяет,
является ли первое число квадратом второго
*/
Console.WriteLine("Введите первое число: ");

int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int userNumber2 = Convert.ToInt32(Console.ReadLine());


int sqNumber2 = userNumber2 * userNumber2;

bool result = userNumber1 == sqNumber2;

Console.WriteLine(result);