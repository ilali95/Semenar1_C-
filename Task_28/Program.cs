﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

void Fact(int namber)
{
	int temp = 1;
	for (int i = 1; i <= namber; i++)
	{
		try
		{
			checked
			{
				temp *= i;
			}
		}
		catch (Exception)
		{
			Console.Write("Переполнение типа! ");
			break;
		}
	}
	Console.WriteLine(temp);
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Fact(num);