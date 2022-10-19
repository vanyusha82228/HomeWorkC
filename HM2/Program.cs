// Задание 1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    int des = num/10;
    int Secondnumber = des %10;
    return Secondnumber;
}


Console.Write("Iput number of threes: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Second digit of the number {number} is {SecondDigit(number)}");