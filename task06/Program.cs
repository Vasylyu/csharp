﻿/*Внутри класса Answer напишите метод CheckIfEven, 
который на вход принимает число number и выводит, 
является ли число чётным (делится ли оно на два без остатка).
*/

System.Console.WriteLine("задай 1 число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    System.Console.WriteLine($"число {number} четное");
}
else
{
    System.Console.WriteLine($"число {number} нечетное");
}