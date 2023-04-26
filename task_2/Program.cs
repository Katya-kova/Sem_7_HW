// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2	
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
PrintArray (GetArray (3,4));

bool FindNum (int [,] Array)
{
    Console.WriteLine("Input number: ");
    int Num = int.Parse(Console.ReadLine());
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j] == Num) return true;
            else return false;
        }
    }
}