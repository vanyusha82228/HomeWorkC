//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++)
            for(int t=j+1;t<array.GetLength(1); t++)
            {
                if(array[i,j]>array[i,t])
                {
                    int temp=array[i,j];
                    array[i,j]=array[i,t];
                    array[i,t]=temp;
                }
            }
}



Console.Write("input number of ROWS: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number of COLUMS: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min posibel value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max posiber value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

SortArray(myArray);
Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[] SumRowsArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for(int i=0; i<array.GetLength(0);i++)
    {
        int sum = 0;
            for(int j=0; j<array.GetLength(1);j++)
                sum+=array[i,j];
        sumArray[i]=sum;
    }
    return sumArray;
}

int ShowMinSumArray(int[,] array)
{
    int min = 0;
    int[] minRowsSum = SumRowsArray(array); 
    for(int i=0;i<minRowsSum.Length;i++)
        if(minRowsSum[i]<minRowsSum[min])
            min=i;
    return min;

}


Console.Write("input number of ROWS: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number of COLUMS: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min posibel value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max posiber value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine(ShowMinSumArray(myArray));

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


//Напишите программу, которая заполнит спирально массив 4 на 4.