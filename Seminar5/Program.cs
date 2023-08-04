//Seminar5

//Task  Задайте массив из m элементов, заполненный случайными числами из
//промежутка [a, b]. Найдите сумму отрицательных элементов массива.


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
    for(int i=0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int SumOfNegatives(int[]array)
{
    int sum =0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<0)
        {
            sum+=array[i];
        }
    }
    return sum;
}
Console.Write("Input length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());
int[]array=CreateRandomArray(length,a,b);
/*
WriteArray(array);
Console.WriteLine(SumOfNegatives(array));
*/

//Task Напишите программу замены элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.

void MultiplyByMinusOneArray(int[]array)
{
    for(int i =0; i< array.Length; i++)
    {

        array[i]*= -1;

    }
    
}
/*
WriteArray(array);
MultiplyByMinusOneArray(array);
WriteArray(array);
*/



//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.
bool IsExistNumber(int[] array, int number)
{
    bool result = false;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]==number)
        {
            result=true;
        }
        
    }
    return result;
}
/*
WriteArray(array);
Console.Write("Input a number, which will check: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(IsExistNumber(array, number));
*/
//Задайте одномерный массив из m случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

int CountInRange(int[]array, int a, int b)
{ 
    int count =0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>a && array[i]<b){
            count++;
        }
    }
    return count;
}
WriteArray(array);
Console.Write("Input number a: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = CountInRange(array, A,B);
Console.Write($"in range from {A} to {B} array elements count :{count}");

