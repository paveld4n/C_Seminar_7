﻿// Задайте двумерный массив размером m*n где значение массива = m+n

Console.WriteLine("Введите количество строк - m");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов - n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибочный ввод! Не цифра! ПереВВедите!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
