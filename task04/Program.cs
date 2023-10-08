/*
Внутри класса Answer напишите метод FindMax, который принимает на вход три числа
 и выдаёт максимальное из этих чисел.
*/
System.Console.WriteLine("Задай 3 числа");
int numbera = Convert.ToInt32(Console.ReadLine());
int numberb = Convert.ToInt32(Console.ReadLine());
int numberc = Convert.ToInt32(Console.ReadLine());
int max = numbera;
if (numberb > max)
{
    max = numberb;
}

if (numberc > max)
{
    max = numberc;
}
System.Console.WriteLine("Максимальное число " + max);
