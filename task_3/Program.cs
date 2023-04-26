// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] GetArray (int length1, int length2)
{
    int [,] Array = new int [length1, length2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(1, 10);
        }
    }
    return Array;
}

void PrintArray(int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


double [] GetAverage (int [,] Array)
{
    double [] result = new double [Array.GetLength(1)];
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            average += Array[i,j];
        }
        result[j] = average / Array.GetLength(1);
    }
    return result;
}

void PrintAverage(double [] Array)
{
    for (int j = 0; j < Array.Length; j++)
    {
        Console.Write(Math.Round(Array[j], 2) + " ");
    }
    Console.WriteLine();
}

PrintArray(GetArray(3,4));
Console.WriteLine();
PrintAverage(GetAverage(Array));


