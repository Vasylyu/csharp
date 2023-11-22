/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number
 и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, 
в противном случае - вывести Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.

14212 -> False
12821 -> True
234322 -> Число не пятизначное False
*/

System.Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n4 = n / 10 % 10;
int n5 = n % 10;

if (n >= 10000 & n <= 99999)
{
    if (n1 == n5 & n2 == n4)
    {
    System.Console.WriteLine("yes");
    }
    else
    System.Console.WriteLine("no");
}
else
{
    System.Console.WriteLine("Здесь не пять чисел");
}
