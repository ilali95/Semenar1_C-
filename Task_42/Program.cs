// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// Console.WriteLine("Число");
// int num1 = Convert.ToInt32(Console.ReadLine());


// void Suma(int num1)
// {
// 	int a = 0;
// 	int i = 0;

// 	while (num1 >= 1)
// 	{
// 		a = num1 % 2;
// 		num1 = num1 / 2;
// 		i++;
// 		Console.Write(a);
// 	};
// }

// Suma(num1);

// Console.Clear();

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());

// int TenToTwo(int n)
// {
//     if (n == 1) return 1;
//     if (n == 0) return 0;
//     return n % 2 + 10 * TenToTwo(n / 2);
// }

// Console.WriteLine(TenToTwo(a));

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Введите основание системы счисления: ");
// int baseNum = int.Parse(Console.ReadLine());

// int d10 = 1;
// int result = 0;
// while (number != 0)
// {
// 	result = result + number % baseNum * d10;
// 	number = number / baseNum;
// 	d10 = d10 * 10;
// }
// Console.WriteLine(result);

int a = 13;
void ToBin(int n, int baseNum)
{
    if (n == 0) return;
    ToBin(n / baseNum, baseNum);
    Console.Write(n % baseNum);
}
ToBin(a, 2);

