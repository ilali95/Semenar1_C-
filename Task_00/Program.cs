// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
// bool b = true;

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.Write($"Квадрат числа {num} = {square}");

// if (num>5)
// {
// 	Console.WriteLine("OK!");
// }
// else Console.WriteLine("Ошибка!");

// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 10 мин
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Write("Введите два целых числа: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}");