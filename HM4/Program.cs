// Задание 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
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
*/



// Задание2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumbers(int num)
{
    int res =0 ;
    while(num!=0)
    {
        int des = num%10;
        res = res+ des;
        num= num/10;
    }
    return res;
}

Console.Write("Input number : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"the sum of the digits {number} of the number is {SumNumbers(number)}");



// Задание3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран