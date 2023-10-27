/*
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.

15:24
Carolina Trifon
a + b > c && a + c > b && b + c > a


Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.
*/

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool CheckTriangleCreation(int a,  int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    return false;
}


int userNumber1 = TakeEnteredNumber("Введите 1 числа");
int userNumber2 = TakeEnteredNumber("Введите 2 числа");
int userNumber3 = TakeEnteredNumber("Введите 3 числа");
System.Console.WriteLine(CheckTriangleCreation(userNumber1,userNumber2, userNumber3));