// Задача1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int EnteringnNumbers(int countMum)
{
    int count = 0;
    int positive = 0;
    while (count < countMum)
    {
        Console.Write("Enter numbers from the keyboard ");
        int number = Convert.ToInt32(Console.ReadLine());
        count++;
        if (number > 0) positive++;
    }
    return positive;
}

Console.Write("Enter count of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"number of positive numbers= {EnteringnNumbers(m)}");
*/

// Задача2.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


string lineIntersection(double k1, double b1, double k2, double b2)
{
    if(k1==k2) return "intersect";
    if (b1==b2) return "parallel";
    
    double x= (b2-b1)/(k1-k2);
    double y= k1*x+b1;
    return $"point of intersection of two lines{(x,y)}";
    
}


Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(lineIntersection(k1,b1,k2,b2));
