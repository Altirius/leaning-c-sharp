// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите Ваше число сюда:");
int number = Convert.ToInt32(Console.ReadLine());
void printRazm(int num)
{
	int i = 1;
	while (num > 10)
	{
		num = num / 10;
		i++;
	}
	Console.WriteLine("Количество цифр в Вашем числе: " + i);
}
printRazm(number);
