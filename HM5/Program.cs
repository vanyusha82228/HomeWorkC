// Задание 1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArreay(int size)  
{
    int[] array = new int[size];

    for(int i=0 ; i<size; i++)
        array[i] = new Random().Next(100,1000);

    return  array;
}

void ShowArray(int[] array) 
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}


int kolvo(int[] array)
{
    int count =0;
    for(int i=0;i<array.Length; i++)
        if (array[i]%2==0)
            count++;
    return count;
}

Console.Write("input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());


int [] myArray = CreateRandomArreay(n);
ShowArray(myArray);

Console.WriteLine($"in array so many even numbers {kolvo(myArray)}");
*/

// Задание 2.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArreay(int size, int minValue, int maxValue)  
{
    int[] array = new int[size];

    for(int i=0 ; i<size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);

    return  array;
}

void ShowArray(int[] array) 
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}

int negativSum(int[] array)
{
    int sum =0;
    for(int i=0;i<array.Length; i++)
        if(i%2!=0)
            sum+=array[i];
    return sum;
}

Console.Write("input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min posibel value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max posiber value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArreay(n, min, max);
ShowArray(myArray);

Console.WriteLine($"the sum of odd array elements is {negativSum(myArray)}");

*/


// Задание 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArreayInt(int size, int minValue, int maxValue)  
{
    int[] array = new int[size];

    for(int i=0 ; i<size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);

    return  array;
}

double[] CreateRandomArreayDouble(int size, int okrug=2)  
{
    double[] array = new double[size];

    for(int i=0 ; i<size; i++)
        array[i]= Math.Round(new Random().NextDouble(),okrug);

    return  array;
}

void ShowArrayInt(int[] array) 
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}

void ShowArrayDouble(double[] array) 
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}
double[] Sumarray(int[] array, double[] array1, int size)
{
    double[] sumArray= new double[size];
    for(int i=0; i<size; i++)
        sumArray[i]=array[i]+array1[i];
    return sumArray;
}

double razn(double[] array)
{
    double max= array[0];
    double min = array[0];
    for(int i=1;i<array.Length; i++)
        if(array[i]>max)
            max = array[i];
        else if(array[i]<min)
            min= array[i];
    return max-min;
}

Console.Write("input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input min posibel value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max posiber value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] intArray = CreateRandomArreayInt(n, min, max);
ShowArrayInt(intArray);

double[] doubleArray=CreateRandomArreayDouble(n);
ShowArrayDouble(doubleArray);

ShowArrayDouble(Sumarray(intArray,doubleArray, n));

Console.WriteLine($"Difference between maximum and minimum array value = {razn(Sumarray(intArray,doubleArray, n))}");