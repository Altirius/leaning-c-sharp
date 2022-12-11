// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите Ваше число сюда:");
int number = Convert.ToInt32(Console.ReadLine());
void printSum(int num)
{
	int sum = 0;
	for (int i = 0; num > 1; i++)
	{
		sum = sum + (num % 10);
		num = num / 10;
	}
	Console.WriteLine("Сумма цифр в Вашем числе: " + sum);
}
printSum(number);
