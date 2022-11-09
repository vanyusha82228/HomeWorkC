// Задание 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen(int num1, int num2)
{
    int res = 1;
    for(int i=1; i<=num2; i++)
    {
        res = res*num1;
    }
    return res;
}

Console.Write("Input fnumber : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Input desired degree : ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"if you raise a number {number} to the power {number2} you get {Stepen(number,number2)}");

// Задание2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Задание3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран