// Задача 24: Напишите программу, которая принимает
//  на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите свое число сюда:");
int number = Convert.ToInt32(Console.ReadLine());
void printSum(int num)
{
	int result = 0;
	for (int i = 0; i <= num; i++)
	{
		result = result + i;
	}
	Console.WriteLine("Сумма чисел от 1 до Вашего: " + result);
}
printSum(number);