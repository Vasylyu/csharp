/*
 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
System.Console.Write("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Number(int a)
{
    int num = 0;

    for (int i = a; i > 0; i = i / 10)
    {
         num++;
    }
    return num;
}
int userResult = Number(userA);
System.Console.WriteLine(userResult);