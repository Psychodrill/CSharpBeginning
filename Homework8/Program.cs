
//Общие условия задания двумерного массива случайными числами

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
int[,] CreateRandomSquareArray(int size, int minValue, int maxValue)
{
    int[,] array = new int[size, size];
    for(int i=0; i<size; i++)
    {
        for(int j=0; j<size; j++)
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
Console.WriteLine();
*/

//Task 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
/*
void DescendingInRows(int [,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            int maxJ =j;
            int max = array[i,maxJ];
            for(int k=j+1; k< array.GetLength(1); k++)
            {
                if(array[i,maxJ] <array[i,k])
                {
                    int tempIndex = maxJ;
                    maxJ=k;
                    k= tempIndex;
                }
            }
            int temp = array[i,j];
            array[i,j]= array[i, maxJ];
            array[i,maxJ]= temp;
        }
    }

}

DescendingInRows(myArray);
Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
/*
int MinSumRow(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    int minSumRow =0;
    int min = sumArray[minSumRow];
    for(int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            sumArray[i]+=array[i,j];
        }
        if(sumArray[minSumRow]> sumArray[i])
        {
            minSumRow=i;
        }
    }
    // for(int i=0; i<sumArray.Length; i++)
    // {
    //     if(sumArray[minSumRow]> sumArray[i])
    //     {
    //         minSumRow=i;
    //     }
    // }
    return minSumRow;
}

int minRow = MinSumRow(myArray);
Console.Write($"Minimum sum row is {minRow}");
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
//произведение двух матриц.
/*
int[,] MatrixMultiply(int[,] firstArray, int[,]secondArray)
{
    int [,] resultArray = new int [firstArray.GetLength(0), secondArray.GetLength(1)];
    for(int i=0; i<resultArray.GetLength(0);i++)
    {
        for (int j=0; j<resultArray.GetLength(1); j++)
        {
            for(int k=0; k<resultArray.GetLength(0); k++)
            {
                resultArray[i,j]+=firstArray[i,k]*secondArray[k,j];
            }

        }
    }

    return resultArray;
}


Console.Write("Input arraySize: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible values: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible values: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstSquareArray = CreateRandomSquareArray(arraySize, min, max);
int[,] secondSquareArray = CreateRandomSquareArray(arraySize, min, max);
Show2dArray(firstSquareArray);
Console.WriteLine();
Show2dArray(secondSquareArray);
int [,] matrixMultiply = MatrixMultiply(firstSquareArray, secondSquareArray);

Console.WriteLine();
Show2dArray(matrixMultiply);
*/
//Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] CreateRandom3dArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] array = new int[x, y, z];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                //array[i,j,k] = new Random().Next(minValue, maxValue+1);
                int number = new Random().Next(minValue, maxValue+1);
                while(IsExistNumber(array, number))
                {
                    number = new Random().Next(minValue, maxValue+1);
                }
                array[i,j,k]=number;
            }
            
        }
    }

    return array;
}


bool IsExistNumber(int[,,] array, int number)
{
    bool result = false;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for (int k=0; k<array.GetLength(2); k++)
            {
                if(array[i,j,k]==number)
                {
                    result=true;
                }
            }
        }
    }
    return result;
}
void Show3dArray(int[,,]array)
{
    for(int k=0; k<array.GetLength(2); k++)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j <array.GetLength(1); j++)
            {
                 Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
      
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Input x measure: ");
int xMeasure = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y measure: ");
int yMeasure = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z measure: ");
int zMeasure = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible values: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible values: ");
int max = Convert.ToInt32(Console.ReadLine());

if(xMeasure*yMeasure*zMeasure<max-min)
{
    int[,,] my3dArray= CreateRandom3dArray(xMeasure,yMeasure,zMeasure,min, max);
    Show3dArray(my3dArray);
}
else{
    Console.Write("Filling array is impossible, because its size greater than count of possible values");
}




//Task 62. Напишите программу, которая заполнит спирально любой двумерный массив.