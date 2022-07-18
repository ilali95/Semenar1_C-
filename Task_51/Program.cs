﻿// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int max = int.Parse(Console.ReadLine());

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
	int[,] arr = new int[m, n];
	Random rnd = new Random();

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rnd.Next(min, max + 1);
		}
	}
	return arr;
}

// int FillMatrix(int[,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(i == j) sum += arr[i, j];
//         }
//     }
//     return sum;
// }

// int FillMatrix(int[,] arr)
// {
//     int sum = 0;
//     int index = 0;
//     if(arr.GetLength(0) > arr.GetLength(1)) index = 1;
//     for (int i = 0; i < arr.GetLength(index); i++)
//     {
//         sum += arr[i, i];
//     }
//     return sum;
// }



int Plus(int[,] arrs)
{
	int sum = 0;
	for (int i = 0; i < arrs.GetLength(0); i++)
	{
		for (int j = 0; j < arrs.GetLength(1); j++)
		{
			if (i == j)
			{
				sum = sum + (arrs[i, j]);
			}
		}

	}
	return sum;
}

void PrintMatrix(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			if (j == 0) Console.Write("|");
			if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
			else Console.Write($"{arr[i, j],3} | ");
		}
		Console.WriteLine();
	}
}

int[,] arrayResult = CreateMatrixRndInt(number, num, min, max);
PrintMatrix(arrayResult);
int a = Plus(arrayResult);
Console.Write(a);
