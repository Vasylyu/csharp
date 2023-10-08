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
else if (numberB>numberA)
{
    System.Console.WriteLine($"число {numberB} больше {numberA}");
}

else if (numberA ==numberB)
{
    System.Console.WriteLine($"число {numberB} равно {numberA}");
}