
//Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create2dRandomArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    Random rand = new Random();
    for(int i=0;i<array.GetLength(0);i++ )
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            int integer = rand.Next(min, max);
            double fraction = rand.NextDouble();
            double rounded = Math.Round(integer+fraction, 3);
            array[i,j]= rounded;
        }
    }
    return array;
}

void Show2dArray(double[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+ "  ");

        }
        Console.WriteLine();
    }
}

Console.Write("Input array rows: ");
int rows =Convert.ToInt32(Console.ReadLine());
Console.Write("Input array columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array element: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,]array = Create2dRandomArray(rows, columns, min, max);

Show2dArray(array);

//Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void FindArrayElement(int i, int j, double[,] array)
{
    if(i<array.GetLength(0) && j<array.GetLength(1))
    {
        Console.WriteLine($"This element is {array[i,j]}");
    }
    else Console.WriteLine("There is no elements with this indexes!");
}


Console.Write("Input array first index: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input array second index: ");
int j = Convert.ToInt32(Console.ReadLine());
FindArrayElement(i,j, array);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

double[] ColumnsAverageValue(double[,] array)
{
    double [] averageValues = new double [array.GetLength(1)];
    //double [] sumValues = new double [array.GetLength(1)];
    for(int i=0;i<array.GetLength(0);i++)
    {
        
        for(int j=0; j<array.GetLength(1); j++)
        {
           //sumValues[j] += array[i, j];
            double sumValues =0;
            for(int k=0; k<=i; k++)
            {
                sumValues+= array[i-k,j];
            }
            averageValues[j]=sumValues/(i+1);
        }
        
    }
   // for(int i=0; i<sumValues.Length; i++)
   // {
   //     averageValues[i]=sumValues[i]/array.GetLength(0);
    //}
    return averageValues;
}

double[] averageValues = ColumnsAverageValue(array);
WriteArray(averageValues);