// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.Write("Введите 1 число:");
string number1 = Console.ReadLine();
Console.Write("Введите 2 число:");
string number2 = Console.ReadLine();
if (Convert.ToInt32(number2) == Convert.ToInt32(number1))
	Console.Write("Вы ввели одинаковые числа");
else
{
	if (Convert.ToInt32(number1) > Convert.ToInt32(number2))
		Console.Write("Число 1 больше числа 2");
	else
		Console.Write("Число 2 больше числа 1");
}