/*
Напишите программу, которая принимает на вход координаты точки (x и y),
причем x и y не равны 0, и выдает номер четверти плоскости, в которой находится эта точка.
*/

string f(int x, int y)
{
    if (x > 0 && y > 0)
        return "I";
    else if (x < 0 && y < 0)
        return "II";
    else if (x < 0 && y < 0)
        return "III";
    return "IV";
}

System.Console.Write("Введите число: ");

int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число: ");

int y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(f(x, y));