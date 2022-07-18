// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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


int[,] Fix(int[,] array1)
{
	for (int i = 0; i < array1.GetLength(0); i++)
	{
		for (int j = 0; j < array1.GetLength(1); j++)
		{
			if (i % 2 == 0 && j % 2 == 0)
			{
				array1[i, j] *= array1[i, j];
			}
		}
	}
	return array1;
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

int[,] arr = Fix(arrayResult);
Console.WriteLine();
PrintMatrix(arr);
