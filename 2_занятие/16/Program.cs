// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 16: Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите 1 число");
float number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
float number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
	if (Math.Pow(number2, 2) == number1)
	{
		Console.WriteLine("Число 1 является квадратом числа 2");
	}
	else { Console.WriteLine("Число 1 не является квадратом числа 2"); }
}
else
{
	if (Math.Pow(number1, 2) == number2)
	{
		Console.WriteLine("Число 2 является квадратом числа 1");
	}
	else { Console.WriteLine("Число 2 не является квадратом числа 1"); }
}