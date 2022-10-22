// Задание 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.





// Задание 2.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
/*
double Rast(double x1, double y1, double z1, double x2, double y2, double z2)
 {
    double kord1 = Math.Pow(x2-x1,2);
    double kord2 = Math.Pow(y2-y1,2);
    double kord3 = Math.Pow(z2-z1,2);
    double rast = Math.Sqrt(kord1+kord2+kord3);
    return rast;
 }

Console.Write("Input first number x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first number y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first number z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first number x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first number y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first number z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Rast(x1, y1,z1, x2, y2,z2));

*/



// Задание 3.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Tabl(int num)
{
    int nach=1;
    while (nach<=num)
    {
        double result = Math.Pow(nach,3);
        Console.WriteLine(result);
        nach++;
    }
}


Console.Write("Input fnumber : ");
int number = Convert.ToInt32(Console.ReadLine());

Tabl(number);
