// Задание 1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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


// Задание 2.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


// Задание 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.