/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

System.Console.WriteLine("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());

int Acerman(int n, int m)
{
    if (n == 0)
     return m + 1;
    else 
      if ((n != 0) && (m ==0))
      return Acerman(n - 1, 1);
    else 
     return Acerman(n - 1, Acerman(n, m - 1));
}

System.Console.WriteLine($" функция Аккермана равна = {Acerman(n, m)}");