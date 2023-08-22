
//Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int PositiveNumbers(int numbers)
{
    int result =0;
    for (int i=0; i<numbers; i++)
    {
        Console.Write("Input integer number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number>0)
        {
            result++;
        }
    }
    return result;
}
Console.Write("Input number count: ");
int numberCount = Convert.ToInt32(Console.ReadLine());
int positiveCount = PositiveNumbers(numberCount);
Console.Write($"Positive numbers count : {positiveCount}");
*/

//Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double[]? ResultDot(double k1,double b1, double k2, double b2){
    double []? result = null;
    if(k1!=k2){
    double x = (b2-b1)/(k1-k2);
    double y =k1*x+b1;
    result = new double [2];
    result[0]=x;
    result[1]=y;
    }
    return result;
}
void WriteArray(double[] array)
{
    for(int i =0; i<array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double []? dot = ResultDot(k1,b1,k2,b2);
if(dot!=null){
    WriteArray(dot);
    
}
else if(b1==b2){
    Console.Write("Ooops, this is one line!");
}
else{
    Console.Write("Ooops, line angles are equal, its have no solutions!");
}
*/
//Task ??: Написать программу, преобразующую число из десятеричной системы счисления в двоичную.

byte[] DivisionEstimates(int number){

    int digits = Convert.ToInt32(Math.Floor(Math.Log2(Convert.ToDouble(number))))+1;

    byte[] estimates = new byte[digits];
    for(int i=estimates.Length-1; i>=0; i--)
    {
        byte estimate = Convert.ToByte(number%2);
        estimates[i]=estimate;
        number=number/2;
    }
    return estimates;
}
void WriteArray(byte[] array)
{
    for(int i =0; i<array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

Console.Write("Input decimal number: ");
int number = Convert.ToInt32(Console.ReadLine());
byte[] estimates = DivisionEstimates(number);

Console.Write($"Binary number is: ");
WriteArray(estimates);

