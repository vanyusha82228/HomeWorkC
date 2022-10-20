// Задание 1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


/*
int SecondDigit(int num)
{
    int des = num/10;
    int Secondnumber = des %10;
    return Secondnumber;
}


Console.Write("Iput number of threes: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Second digit of the number {number} is {SecondDigit(number)}");
*/


// Задание2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int Dev(int num)
{
    if (num > 99 && num < 1000)
    {
        int third = num % 10;
        return third;
    }
    if (num > 0 && num < 100)
    {
        int third = -1;
        return third;
    }
    if (num > 999 && num < 10000)
    {
        int fourth = num / 10;
        int third = fourth %10;
        return third;
    }
    if (num > 9999 && num < 100000)
    {
        int fifth = num / 100;
        int third = fifth %10;
        return third;
    }
}

Console.Write("Iput the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Dev(number));
*/

// Задание3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool DayOfTheWeek(int num)
{
    if (num >=8 || num<= 0)
    {
        Console.WriteLine("invalid number");
        return false;
    }
    
    if (num >=5 && num <= 7)
    {
        Console.WriteLine("It's the weekend");
        return true;
    }
    else
    {
        Console.WriteLine("it's not a day off");
        return false;
    }


}

Console.Write("Iput the number of the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DayOfTheWeek(number));



