


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