// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    Console.Write(n+" ");
    if(n>1) ShowNums(n-1);   
}

ShowNums(5);
*/

//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumElements(int m, int n)
{
    if(m>n) 
        return SumElements(m,n+1)+m;
    else if(m<n)
        return SumElements(m+1,n)+m;
    else
        return m;
    
}

Console.WriteLine(SumElements(1,5));
*/
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int firstElement, int secondElement)
{
    if(firstElement==0)
        return secondElement+1;
    else if(firstElement>0 && secondElement== 0)
        return Ackerman(firstElement-1,1);
    else 
        return Ackerman(firstElement-1,Ackerman(firstElement,secondElement-1));
}

Console.Write("input Feirst number : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input  seconf number : ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Ackerman(m,n));