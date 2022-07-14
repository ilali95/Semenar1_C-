// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Число: ");
int nom = int.Parse(Console.ReadLine());

int ToBin(int a)
{
	// f(n) =f(n-1) +f( n-2)
	int d = 0;
	int b = 1;
	int suma = 0;
	Console.Write($"{d} {b}");
	for (int i = 0; i < nom; i++)
	{
		suma = d + b;
		d = b;
		b = suma;
		Console.Write($" {suma}");
	}
	return suma;
}

ToBin(nom);


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] Feb(int size)
// {

//     int[] arr = new int[size];
//     arr[0] = 0;
//     arr[1] = 1;
//     for (int i = 2; i < size; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     return arr;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i] + "]");
//     }
// }
// int[] Array = Feb(num);
// PrintArray(Array);
