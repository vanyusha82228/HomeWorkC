// Задача1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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


// Задача2.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.