/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

System.Console.Write("Введите число: ");
int zema = Convert.ToInt32(Console.ReadLine());

int Symm(int a)
{
    int result = 0;
    for (int i = a; i > 0; i/=10)
    {
        result = result + i % 10;
    }
    return result;
}
int userresult = Symm(zema);
System.Console.WriteLine(userresult);