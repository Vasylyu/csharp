/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
Console.Write("Введите количество чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine());

if (N < 0)
{
    Console.WriteLine("Пожалуйста, введите положительное число.");
    return;
}

if (N == 0)
{
    Console.WriteLine("Если " + N + " число Фибоначчи: 1");
    return;
}

int first = 0;
int second = 1;

Console.Write("Если " + N + " число Фибоначчи: ");

if (N >= 1)
{
    Console.Write(first);
}

if (N >= 2)
{
    Console.Write(", " + second);
}

for (int i = 3; i <= N; i++)
{
    int next = first + second;
    Console.Write(", " + next);
    first = second;
    second = next;
}

Console.WriteLine();

