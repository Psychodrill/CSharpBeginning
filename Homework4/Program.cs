//Task 25. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
int PoweredNumber(int number, int power)
{
    int result=1;
    if(power>0)
    {
        for (int i=1; i<=power; i++)
        {
            result*=number;
        }


    }
    return result;
}

Console.Write("Input a number, which required to power: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a power of number: ");
int power = Convert.ToInt32(Console.ReadLine());
int result =PoweredNumber(number, power);
Console.WriteLine($"Number {number} powered {power} is: {result}");
*/
//Task 27. Напишите программу, которая принимает на вход число и
//выдаёт сумму цифр в числе.
/*
int DigitSum(int number)
{
    int result =0;
    while(number>0)
    {

        result+=number%10;
        number= number/10;
      
    }
    return result;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = DigitSum(number);
Console.WriteLine($"Digit sum is {sum}");
*/


//Task 29. Напишите программу, которая задаёт массив из m элементов
//и выводит их на экран.

int[] InputedArray(int size)
{
    int[]array = new int[size];

    for(int i =0; i< size; i++)
    {
        Console.Write($"Input element of an array witn index {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[");
    for(int i =0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if(i!=array.Length-1)
        {
            Console.Write(", ");
        }
        
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray= InputedArray(length);
WriteArray(myArray);
