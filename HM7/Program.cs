// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue, int okrug=1)
{
    double[,] array = new double[rows, colums];
    
    for(int i=0; i<rows; i++)
        for(int j=0;j<colums; j++)
        {
            array[i,j]= new Random().Next(minValue, maxValue);
            array[i,j]+= Math.Round(new Random().NextDouble(),okrug);
        }
            
    return array;
}

void ShowInt2dArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0;j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("input number of ROWS: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number of COLUMS: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min posibel value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max posiber value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m,n,min,max);

ShowInt2dArray(myArray);

*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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
string FindValue(int[,] array, int posRows, int posColums)
{
    if (posRows < array.GetLength(0) && posColums < array.GetLength(1))
        return array[posRows, posColums].ToString();
    else
        return "error";
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

Console.Write("");
Console.Write("input posRows: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input posColums: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindValue(myArray, pos1, pos2));


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

