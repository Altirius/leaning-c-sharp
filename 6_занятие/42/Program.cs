// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void convert010()
{
	Console.WriteLine("Введите число вот сюда, пожалуйста:");
	int number = Convert.ToInt32(Console.ReadLine());
	string number010 = "";
	while (number > 0)
	{
		if ((number % 2) == 1)
		{
			number010 = "1" + number010;
		}
		else
		{
			number010 = "0" + number010;
		}
		number = number / 2;
	}
	Console.WriteLine("Оказывается, Ваше число в двоичном виде вот такое: " + number010);
}
convert010();