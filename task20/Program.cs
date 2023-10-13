/*
Напишите программу, которая принимает на вход координаты двух точек
 и находит рассояние между ними в 2D пространстве.
*/

System.Console.Write("Введите число: ");

int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число: ");

int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число: ");

int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число: ");

int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2);

System.Console.WriteLine(d);