//Task 19. Напишите программу, которая принимает на вход  число
// и проверяет, является ли оно палиндромом.

bool isPalindrom(int number)
{
    bool result =false;
    int estimate=0;
    int reverseNumber=0;
    int current = number;
    while(current >0)
    {
        estimate = current%10;
        current = current/10;
        reverseNumber=reverseNumber*10+estimate;
    }
    if(reverseNumber==number){
        result=true;
    }
    
    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isPalidrom = isPalindrom(number);
if(isPalidrom){
    Console.Write($"Yes, number  {number} is palindrom");
}
else{
     Console.Write($"No, number  {number} is not palindrom");
}


//Task 21. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result=0;
    int deltaX = x2-x1;
    int deltaY = y2-y1;
    int deltaZ = z2-z1;
    result = Math.Sqrt(Math.Pow(deltaX,2)+Math.Pow(deltaY,2)+ Math.Pow(deltaZ,2));
    return result;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Distance3D(x1, y1, z1, x2, y2, z2),2);
Console.Write($"Distance between points is {distance}");
*/

//Task 23. Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
/*
void WritePows(int number)
{
   int current=1;
    while(current <=number)
    {
        Console.WriteLine($"{current}: {current*current*current}");
        current++;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
WritePows(number);
*/
//более универсальная реализация
/*
void WritePows(int number, int power)
{
   int current=1;
    while(current <=number)
    {
        Console.WriteLine($"Power of {current} is: {Math.Pow(current, power)}");
        current++;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input power: ");
int power = Convert.ToInt32(Console.ReadLine());
WritePows(number, power);
*/
