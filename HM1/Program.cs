// Task 1  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Number {number1} more than {number2}");
    Console.WriteLine($"Number {number2} less than {number1}");
}
else
{
    Console.WriteLine($"Number {number2} more than {number1}");
    Console.WriteLine($"Number {number1} less than {number2}");
}

*/

// Task 2   Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input int first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  int second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  int third number ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1 ;

if (number2 > max)
{
    max= number2;
}
if (number3 > max)
{
    max= number3;
}

Console.WriteLine($"The largest number {max}");

*/




// Task 3   Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input int number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2==0)
{
    Console.WriteLine($"number {number} is even ");
}
else
{
    Console.WriteLine($"number {number} odd ");
}
*/



// Task 4  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input int number ");
int number = Convert.ToInt32(Console.ReadLine());

int nach = 1;

while (nach <= number)
{
    if(nach%2==0)
    {
        Console.Write(nach);
    }
    nach++;
}
*/