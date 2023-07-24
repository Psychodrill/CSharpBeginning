// Seminar2

//Theory

/*
13254/10 = 1325
13254/100 = 132
13254/1000 = 13
13254/10000 = 1

13254 %10 = 4
13254 %100 = 54
13254 %1000 = 254
13254 %10000 = 3254

24365 -> 43 
/100 потом %100
*/

//Task 1 Напишите программу, которая выводит случайное трёхзначное число
//и удаляет вторую цифру числа
/*
int CutNumber(int num)
{
    int hundreds = num /100;
    int units = num %10;

    int res = hundreds*10 + units;
    return res;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

//Task 2 Напишите программу, которая принимает на вход число и проверяет
// кратно ли оно a и b 
/*
bool IsDivisible(int num, int div1, int div2)
{
    // if(num % div1 ==0 && num% div2 ==0)
    // {
    //     return true;
    // }
    // else
    // {
    //     return false;
    // }
    return num % div1 ==0 && num% div2 ==0;
}

Console.Write("Input number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 =Convert.ToInt32(Console.ReadLine());
bool res = IsDivisible(number, divider1, divider2);
if (res) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/
//Task 3 Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxDigitOfNumber(int number)
{
    int result =0;
    int decimals = number/10;
    int units = number%10;
    if(decimals>units)
    {
        result=decimals;

    }
    else{
        result=units;
    }
    return result;
}

int rndNumber= new Random().Next(10,100);
int maxDigit = MaxDigitOfNumber(rndNumber);
Console.WriteLine($"max digit o {rndNumber} is {maxDigit}");
*/
//Task 4 Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

bool IsPowerOfAnyNumbers(int number1, int number2){
    
   return (number1 *number1 ==number2 || number2*number2 ==number1);
}

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 =Convert.ToInt32(Console.ReadLine());


bool result = IsPowerOfAnyNumbers(number1, number2);

if (result) Console.WriteLine("Yes");
else Console.WriteLine("No");