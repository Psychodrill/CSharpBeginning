
//Task Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{



    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void Show2dArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j <array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
/*
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible values: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible values: ");
    int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows,columns, min, max);
Show2dArray(myArray);
*/

//Task Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] Create2dArray(int m, int n)
{
    int[,] array = new int[m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            array[i,j] = i+j;
        }
    }
    return array;
}


    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] myArray = Create2dArray(rows, columns);
    Show2dArray(myArray);
    
//Task Задайте двумерный массив. Найдите элементы, у которых
//оба индекса чётные, и замените эти элементы на их квадраты.

void ReplaceEvenElements(int[,] array)
{
   
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            if(array[i,j]%2==0)
            {
                //array[i,j] = array[i,j]^2;
                array[i,j] = array[i,j]*array[i,j];
            }
            
        }
    }

}

//ReplaceEvenElements(myArray);
//Show2dArray(myArray);

//Task Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumOfMainDiag(int[,] array)
{
    int result =0;
    for(int i=0, j=0; i<array.GetLength(0);i++, j++){
       // for(int j=0; j<array.GetLength(1); j++){
           // if(i==j){
                result+=array[i,j];
            //}
       // }
    }
    return result;
}

int result = SumOfMainDiag(myArray);
Console.Write($"Sum: {result}");