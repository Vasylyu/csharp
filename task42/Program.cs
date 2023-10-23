/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/


/*/
string FindMax(int number)
{
    string result = ""
    int tmp = 0;
    for (int i = number; i >0; i/=2)
    {
       tmp = i % 2;
       result = tmp + result;
    }
    return result
}
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ToBinary( int number)
{
    int result= 0;
    int ten = 1;
    while(number>0){
        result=number%2*ten+result;
        number=number/2;
        ten=ten*10;
    }
return result;
}
int Number = ToBinary(number);
Console.Write(Number);

