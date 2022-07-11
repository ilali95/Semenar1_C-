// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.WriteLine("Введите четверть: ");
int ch = Convert.ToInt32(Console.ReadLine());

string Quarter(int che);
{
	// string = che;
	switch (int che)
	{
		case 1:  x > 0 && y > 0 break;
		case 2:  x < 0 && y > 0 break;
		case 3:  x < 0 && y < 0 break;
		case 4:  x > 0 && y < 0 break;
		default: Введены некоректные координаты;
		break;
	}
}
string result = Quarter(che);
Console.WriteLine(result);

// string result = Quarter(x, y);
// Console.WriteLine(result);
// Console.Clear();
// Console.WriteLine("ВВедите четверть: ");
// int nul = Convert.ToInt32(Console.ReadLine());
// switch (nul)
// {
//     case 1: Console.WriteLine("x > 0 && y > 0"); break;
//     case 2: Console.WriteLine("x < 0 && y > 0"); break;
//     case 3: Console.WriteLine("x < 0 && y < 0"); break;
//     case 4: Console.WriteLine("x > 0 && y < 0"); break;
//     default: Console.WriteLine("Нет решений"); break;
// }

// Console.ReadKey();
