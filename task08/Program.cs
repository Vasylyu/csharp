/*
Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number),
 а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

 number = 5 -> 2    4

number = 8 -> 2    4    6    8
*/
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i+=2)
{
    System.Console.WriteLine(i + "\t");
}