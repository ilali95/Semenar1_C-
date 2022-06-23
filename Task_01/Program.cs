int num1, num2;

Console.WriteLine("Введите число 1:");
num1 = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine("Введите число 2:");
num2 = Convert.ToInt32(Console.ReadLine()); ;

if (num1 == num2 * num2)
	Console.WriteLine($"{num1} является квадратом числа {num2}");
else
	Console.WriteLine($"{num1} не является квадратом числа {num2}");