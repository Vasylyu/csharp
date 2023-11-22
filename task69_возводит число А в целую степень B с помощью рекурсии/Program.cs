/*
Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии.
 */

System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите cтепень: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int IntN(int n1, int n2)
{
    if (n2 == 1) return n1;
    else
        return n1 * IntN(n1, n2 - 1);
}
int result = IntN(number1,number2);
System.Console.WriteLine(result);