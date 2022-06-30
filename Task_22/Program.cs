// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Write("Введите чисол: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
	Console.WriteLine($"|{n,4} = |{i * n,4}|");
}


Console.WriteLine();

// 	}
// }
// Console.Clear();
// Console.WriteLine("Введите  число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= num)
// {
// 	Console.WriteLine($"{i, 4}   |    {i * i, 4}");
// 	i++;
// }