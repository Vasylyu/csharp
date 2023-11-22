/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
System.Console.Write("Введите число A: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int y = Convert.ToInt32(Console.ReadLine());

void Naturel(int a, int b)
{

    double zzz = (Math.Pow(a, b));
    System.Console.WriteLine(zzz);
}

Naturel(x, y);

