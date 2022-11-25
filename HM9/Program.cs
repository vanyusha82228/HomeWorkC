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

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.