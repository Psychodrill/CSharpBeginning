
//Task 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int number)
{
    
    Console.Write(number + " ");
    number--;
    if(number>0)
    {
        ShowNumbers(number);    
    }

}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/

//Task 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int NaturalNumbersSum(int min, int max, int sum=0)
{
    if(min<=max)
    {
        sum+=min;
        min++;
        sum = NaturalNumbersSum(min, max, sum);
    }
    
return sum;
}

Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int sum = NaturalNumbersSum(min, max);
Console.Write($"Result sum is {sum}");
*/
//Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction(int a, int b, int result=0)
{
    if(a==0)
    {
        result = b+1;
    }
    if(b==0)
    {
        result= AckermannFunction(a-1, 1, result);
    }
    if(a>0 && b>0)
    {
       
        result = AckermannFunction(a-1, AckermannFunction(a, b-1, result), result);
    }

    return result;
}
Console.Write("Input number a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(numberA, numberB);
Console.Write($"Result  is {result}");
