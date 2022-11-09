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
/*
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
*/


// Задание3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран
int[] CreateRandomArreay(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i=0 ; i<size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);

    return  array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}

Console.Write("input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the minimum value in the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the Maximum value in the array: ");
int max = Convert.ToInt32(Console.ReadLine());


int [] Array = CreateRandomArreay(n, min, max);
ShowArray(Array);