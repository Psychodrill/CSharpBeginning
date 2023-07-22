
    //Homework1
    //Task 2. Напишите программу которая на вход принимает 2 числа и выдаёт какое большее а какое меньшее
    /*    
    Console.WriteLine("Input a first number: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a second number: ");
    int secondNum= Convert.ToInt32(Console.ReadLine());

    if(firstNum>secondNum)
    {
        Console.WriteLine($"max number is: {firstNum} and min number is: {secondNum}");
    }
    else
    {
        Console.WriteLine($"max number is: {secondNum} and min number is: {firstNum}");
    }
    */

    //Task 4. Напишите программу которая на вход принимает 3 числа и выдаёт максимальное из этих чисел
    /*
    Console.WriteLine("Input a first number: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a second number: ");
    int secondNum= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a third number: ");
    int thirdNum= Convert.ToInt32(Console.ReadLine());

    if(firstNum>secondNum &&firstNum>thirdNum)
    {
        Console.WriteLine($"max number is: {firstNum}");
    }
    if(secondNum>firstNum && secondNum>thirdNum)
    {
        Console.WriteLine($"max number is: {secondNum}");
    }
    if(thirdNum>firstNum && thirdNum>secondNum)
    {
        Console.WriteLine($"max number is: {thirdNum}");
    }
    */

    //Task 6. Напишите программу которая на вход принимает число и выдаёт является ли число чётным
    /*
    Console.WriteLine("Input a number: ");
    int number= Convert.ToInt32(Console.ReadLine());

    if(number%2==0)
    {
        Console.WriteLine("Great, this number is even");
    }
    else
    {
        Console.WriteLine("Unlucky, this number is odd");
    }
    */
    
    //Task 8. Напишите программу которая на вход принимает число N а на выходе показывает все чётные сила от 1 до N

    Console.WriteLine("Input a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int currentNumber = 1;
    while(currentNumber<=number)
    {
        if(currentNumber%2==0){
            Console.Write(currentNumber + " ");
        }
        currentNumber++;
    }
