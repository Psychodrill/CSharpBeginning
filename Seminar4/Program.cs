
//Task 1. Напишите программу, которая принимает на вход число A 
//а на выходе выдаёт сумму чисел от 1 до A
/*
int Summ(int number)
{
    int summ =0;
   for(int i=0; i<=number; i++)
   {
    summ+=i;
   }
    return summ;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = Summ(number);
Console.WriteLine($"Sum is {summ}");
*/
//Task 2. Напишите программу, которая принимает на вход число и 
//выдаёт количество цифр в числе.
/*
int DigitCount(int number)
{
    int count =0;
    while(number>0)
    {
       number= number/10;
       count++;
    }
    return count;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = DigitCount(number);
Console.WriteLine($"Digit count is {count}");
*/


//Task 3. Напишите программу, которая принимает на вход число N и 
//выдаёт произведение нечетных чисел от 1 до N.
/*
int MultiOdd(int number)
{
    int multiOdd =1;
   for(int i=0; i<=number; i++)
   {
    if(i%2!=0)
    {
        multiOdd=multiOdd*i;
        i++;
    }
    
   }
    return multiOdd;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int product = MultiOdd(number);
Console.WriteLine($"Product is {product}");
*/
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]array = new int[size];

    for(int i =0; i< size; i++)
    {
        array[i]= new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for(int i =0; i<array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min of possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max of possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray= CreateRandomArray(length, min, max);
WriteArray(myArray);

