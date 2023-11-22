/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/


System.Console.WriteLine("задай первое число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("задай второе число");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if ( userNumber1 % userNumber2 == 0)
{
    System.Console.WriteLine($"число {userNumber1} кратное");
}
else
{
    int result = userNumber1 % userNumber2;
    System.Console.WriteLine($"число {result} некратное");
}
