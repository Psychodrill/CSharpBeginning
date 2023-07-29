//Seminar3

//Task 1. Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y)
/*
void WriteRange(int quandrant)
{
    if(quandrant<1 || quandrant>4)
    {
        Console.WriteLine("Uncorrect data!");

    }
    else if(quandrant ==1)
    {
        Console.WriteLine("x>0 and y>0");
    }
    else if(quandrant ==2)
    {
        Console.WriteLine("x<0 and y>0");
    }
    else if(quandrant ==3)
    {
        Console.WriteLine("x<0 and y<0");
    }
    else{
        Console.WriteLine("x>0 and y<0");
    }
}
Console.Write("Input a number of quadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());
WriteRange(quad);
*/
//Task 2. Напишите программу, которая принимает на вход координаты точки
// (x и y) и выдаёт номер четверти плоскости, в которой находится эта точка
/*
int GetQuadrantNumber(int x, int y)
{
    int result = -1;
    // if(x ==0|| y==0)
    // {
    //     result =0;

    // }
    if(x>0 && y>0)
    {
        result=1;
    }
    else if(x<0 && y>0)
    {
        result=2;
    }
    else if(x<0 && y <0)
    {
        result=3;
    }
    else if(x>0 && y <0){
        result=4;
    }
    return result;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
int quadrantNumber = GetQuadrantNumber(x, y);
Console.WriteLine($"Point in quadrant: {quadrantNumber}");
*/

//Task 3. Напишите программу, которая принимает на вход число N
// и выдаёт квадраты чисел от 1 до N
/*
void WritePows(int number)
{   int count=1;
    while(count <=number)
    {
        Console.WriteLine($"{count}: {count*count}");
        count++;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
WritePows(number);
*/

//Task 4. Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними на плоскости координат

double Distance(int x1, int y1, int x2, int y2)
{
    double result=0;
    int diffX = Math.Abs(x2-x1);
    int diffY = Math.Abs(y2-y1);

    result = Math.Sqrt(Math.Pow(diffX,2)+Math.Pow(diffY,2));
    return result;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance=Math.Round(Distance(x1,y1,x2,y2),2);
Console.Write($"Distance between points: {distance}");