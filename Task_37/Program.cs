// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер масива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("От");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("До");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
	int[] arr = new int[size];
	Random rnd = new Random();

	for (int i = 0; i < size; i++)
	{
		arr[i] = rnd.Next(min, max + 1);
	}
	return arr;
}

int[] NewArray(int [] arr)
{
	for (int i = 0; i < arr.length; i++)
	{
		if ( i < arr.length/2) 
		{
			arr[i]= arr[i]*arr[size-1];
		}
	}
}

int[] array = CreateArrayRndInt(123, 0, 1000);