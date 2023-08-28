//Task Задайте двумерный массив.
//Напишите программу, которая поменяет местами указанные строки массива. 

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

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1>=0 && r1<array.GetLength(0) &&
        r2>=0 && r2<array.GetLength(0)&&
        r1 != r2)
    {
        for(int j=0; j< array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1,j]= array[r2,j];
            array[r2,j] = temp;
        }
    }
}


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

// Console.Write("Input a number of first row change:");
// int row1 = Convert.ToInt32(Console.ReadLine())-1;
// Console.Write("Input a number of second row change:");
// int row2 = Convert.ToInt32(Console.ReadLine())-1;

// ChangeRows(myArray, row1, row2);
// Show2dArray(myArray);


//Task Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

void ReplaceRowsToColumns(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(j>i && array.GetLength(0)== array.GetLength(1))
            {
                 int temp = array[i, j];
                array[i,j]= array[j,i];
                array[j,i] = temp;
            }

        }
    }
}

//ReplaceRowsToColumns(myArray);
//Show2dArray(myArray);
//Task Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.WriteLine();
int[,] ChangedArray(int[,] array)
{
    int [,] result = new int[array.GetLength(0)-1, array.GetLength(1)-1 ];
    //int min = array[0,0];
    int minI= 0;
    int minJ =0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(array[i,j]<array[minI,minJ] )
            {
                minI = i;
                minJ=j;
            }

        }
    }
    //Console.WriteLine($" minI ={minI} minJ = {minJ}");
    for(int i=0; i<result.GetLength(0); i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
        {
            if(i<minI && j<minJ)
            {
                result[i,j]=array[i,j];
            }
            if(i<minI && j>=minJ)
            {
                result[i,j]=array[i,j+1];
            }
             if(i>=minI && j<minJ)
            {
                result[i,j]=array[i+1,j];
            }
            if(i>=minI && j>=minJ)
            {
                result[i,j]=array[i+1,j+1];
            }
        }
    }
    return result;
}

int[,] changedArray = ChangedArray(myArray);
Show2dArray(changedArray);