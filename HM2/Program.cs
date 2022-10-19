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





// Задание3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool DayOfTheWeek(int num)
{
    if (num >5 && num < 8)
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
*/


