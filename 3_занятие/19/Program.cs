// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 10000) && (number < 99999))
{
	int number1 = number / 10000;
	int number2 = (number % 10000) / 1000;
	int number3 = (number % 1000) / 100;
	int number4 = (number % 100) / 10;
	int number5 = number % 10;
	if ((number1 == number5) && (number2 == number4))
	{
		Console.WriteLine("Поздравляю!Вы нашли палиндром :)");
	}
	else
	{
		Console.WriteLine("Это число - не палиндром, но оно хотя бы пятизначное :)");
	}
}
else
{
	Console.WriteLine("Ваше число не пятизначное. Поищите другое :)");
}