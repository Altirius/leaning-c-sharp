// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите 1 число:");
string number1 = Console.ReadLine();
Console.Write("Введите 2 число:");
string number2 = Console.ReadLine();
Console.Write("Введите 3 число:");
string number3 = Console.ReadLine();
if ((Convert.ToInt32(number2) == Convert.ToInt32(number1)) && (Convert.ToInt32(number3) == Convert.ToInt32(number1)))
{
	Console.Write("Вы ввели одинаковые числа");
}
else
{
	if (Convert.ToInt32(number1) > Convert.ToInt32(number2))
	{
		if (Convert.ToInt32(number1) > Convert.ToInt32(number3))
		{
			Console.Write("Число 1 - самое большое");
		}
		else
		{
			Console.Write("Число 3 - самое большое");
		}
	}
	else
	{
		if (Convert.ToInt32(number2) > Convert.ToInt32(number3))
		{
			Console.Write("Число 2 - самое большое");
		}
		else
		{
			Console.Write("Число 3 - самое большое");
		}
	}
}
