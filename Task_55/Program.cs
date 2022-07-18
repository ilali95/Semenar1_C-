﻿// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Введите число: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите число: ");
// int max = int.Parse(Console.ReadLine());

// Console.Clear();
// int[,] CreateMatrixRndInt(int m, int n, int min, int max)
// {
// 	int[,] arr = new int[m, n];
// 	Random rnd = new Random();

// 	for (int i = 0; i < arr.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < arr.GetLength(1); j++)
// 		{
// 			arr[i, j] = rnd.Next(min, max + 1);
// 		}
// 	}
// 	return arr;
// }

// int [,] ExchangeMatrix(int[,] array)
// {
// 	if (array.GetLength(0)!=array.GetLength(1)) Console.WriteLine(Невозможно);
// 	for (int i = 0; i < arr.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < arr.GetLength(1); j++)
// 		{
// 			array[j] = array[i];
// 		}
// 	}
// 	return array;
// }

// void PrintMatrix(int[,] arr)
// {
// 	for (int i = 0; i < arr.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < arr.GetLength(1); j++)
// 		{
// 			if (j == 0) Console.Write("|");
// 			if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
// 			else Console.Write($"{arr[i, j],3} | ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// int[,] arrayResult = CreateMatrixRndInt(number, num, min, max);
// PrintMatrix(arrayResult);


// int [,] array1 = ExchangeMatrix(arrayResult);
// Console.WriteLine(array1);

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


int[,] ExchangeMatrix(int[,] array)
{
	int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			newArray[i, j] = array[j, i];
		}
	}
	return newArray;
}


void PrintMatrix(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			if (j == 0) Console.Write("|");
			if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3}| ");
			else Console.Write($"{arr[i, j],3} |");
		}
		Console.WriteLine();
	}
}


int[,] arrayResult = CreateMatrixRndInt(4, 4, 1, 5);
PrintMatrix(arrayResult);
Console.WriteLine();
if (arrayResult.GetLength(0) != arrayResult.GetLength(1)) Console.WriteLine("Невозможно произвести замену");
else
{
	int[,] arrResult = ExchangeMatrix(arrayResult);
	PrintMatrix(arrResult);
}