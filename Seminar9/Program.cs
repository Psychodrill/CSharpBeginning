//Task63  Задайте значение N. Напишите программу, которая выведет все натуральные
//числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

void ShowNumbers(int number, int count=0)
{
    count++;
    Console.Write(count + " ");
    
    if(count<number)
    {
        ShowNumbers(number, count);    
    }

}
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/
//Task 65: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

void ShowNaturalNumbers(int min, int max, int count=0)
{
    if(min>count) count=min;
    
    else count++;
    
    Console.Write(count + " ");
    
    if(count<max)
    {
        ShowNaturalNumbers(min, max, count);    
    }

}
/*
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(min, max);
*/
//Задача 67: Напишите программу, которая будет принимать на вход
//число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
/*
int SumOfDigits()
{
    return 0;
}
*/
//Задача 69: Напишите программу, которая на вход принимает
//два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int PoweredNumber(int number, int power, int result=0)
{
    if(power>0)
    {
        if(result<number) result = number;
        else result*=number;
        power--;
        result =PoweredNumber(number, power, result);
    }

return result;

}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power: ");
int power = Convert.ToInt32(Console.ReadLine());
int powNumber =PoweredNumber(number, power);
Console.Write($"Result number: {powNumber}");
