/*
Внутри класса Answer напишите метод CompareNumbers,
который на вход принимает два числа и выводит, 
какое число большее, а какое меньшее.
*/
System.Console.WriteLine("Введите первое число");


int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    System.Console.WriteLine($"число {numberA} больше {numberB}");
}
else 
{
    System.Console.WriteLine($"число {numberB} больше {numberA}");
}