//Task 10. Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int GetSecondDigit(int num)
{
    int decimals = num/10;
    int result = decimals%10;
    return result;
}

Console.Write("Input three-digit number :");
int number =Convert.ToInt32(Console.ReadLine());
int secondDigit =GetSecondDigit(number);
Console.WriteLine($"The second digit of {number} is: {secondDigit}");
*/
//Task 13. Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа ( или -1, если третьей цифры нет).
/*
int GetThirdDigit(int num)
{
    int result=-1;
    if(num>=1000)
    {
        while(num>=1000)
        {
            num = num/10;
        }
        result = num%10;
    }
    return result;
}

Console.Write("Input a number :");
int number =Convert.ToInt32(Console.ReadLine());
int thirdDigit =GetThirdDigit(number);
if (thirdDigit !=-1)
{
    Console.WriteLine($"The third digit of {number} is: {thirdDigit}");
}
else
{
    Console.WriteLine($"The third digit of {number} is absent");
}
*/
// Task 15. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным

bool IsAmericanWeekend(int num)
{
    bool result = false;
    if(num==1 || num ==7)
    {
        result=true;
    }
    return result;
}

Console.Write("Input number day of week from 1 to 7 to get american weekend: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if(dayNumber>0 && dayNumber<=7){
    if(IsAmericanWeekend(dayNumber)){
        Console.WriteLine("Yes, this day number is american weekend");
    }
    else{
        Console.WriteLine("No, this day number isn't american weekend");
    }
}
else{
    Console.WriteLine("Unfortunately, you have input incorrect number, now apologize immediately and shut down program");
}
