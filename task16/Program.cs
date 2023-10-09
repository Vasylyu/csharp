/*
.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
System.Console.WriteLine("Введите первое число");

int usernumber1 = Convert.ToInt32(Console.ReadLine()); // 5

System.Console.WriteLine("Введите второе число"); 

int usernumber2 = Convert.ToInt32(Console.ReadLine()); // 25


if (usernumber1 * usernumber1 == usernumber2 || usernumber2 * usernumber2 == usernumber1)

System.Console.WriteLine("кратны");

else
{
    System.Console.WriteLine("некратны");
}
