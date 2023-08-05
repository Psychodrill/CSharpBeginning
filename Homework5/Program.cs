//Task 34  Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[]array = new int[size];

    for(int i =0; i< size; i++)
    {
        array[i]= new Random().Next(100, 1000);
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

int EvenNumbers(int[]array)
{
    int result=0;
    for (int i=0; i<array.Length;i++)
    {
        if(array[i]%2==0)
        {
            result++;
        }
    }
    return result;
}
Console.Write("Input length of three-digit element array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(arraySize);
WriteArray(array);
int evenNumbers = EvenNumbers(array);
Console.Write($"Even numbers is: {evenNumbers}");
*/

//Task 36. Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
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

int OddIndexValuesSum(int[]array)
{
    int sum=0;
    for(int i=0; i<array.Length;i++)
    {
        if(i%2!=0)
        {
            sum+=array[i];
            i++
        }
    }
    return sum;

}

Console.Write("Input array length: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max length: ");
int max = Convert.ToInt32(Console.ReadLine());
int[]array=CreateRandomArray(size,min,max);
WriteArray(array);
int sum = OddIndexValuesSum(array);
Console.Write($"The sum is {sum}");
*/

//Task 38.  Задайте массив вещественных чисел. Найдите разницу
//между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int min, int max)
{
    double[]array = new double[size];
    Random rand= new Random();
    for(int i =0; i< size; i++)
    {
        int integer = rand.Next(min, max+2);
        double fraction = rand.NextDouble();
        array[i]= integer + fraction;
    }
    return array;
}
void WriteArray(double[] array)
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

double MaxDelta(double[]array)
{
    double min=array[0];
    double max=array[0];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<min){
            min= array[i];
        }
        if(array[i]>max){
            max=array[i];
        }
    }

    return max-min;
}



Console.Write("Input array length: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max length: ");
int max = Convert.ToInt32(Console.ReadLine());
double[]array=CreateRandomArray(size, min, max);
WriteArray(array);
double delta= MaxDelta(array);
Console.Write($"Maximum delta of array is: {delta}");