// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"чисел: {Console.ReadLine().Length}");
// Console.WriteLine($"{num} -> {num.ToString().Length}");
// Console.Write("Числа нет");
// for (int i = 0; i < num; i++)
// {
// 	num = num / 10;
// }
// Console.WriteLine($"{num} -> {i}");

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (num > 0)
{
    i++;
    num /= 10;
}
Console.WriteLine("Количество цифр введенного числа : {0}", i);
