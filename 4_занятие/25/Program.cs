// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите в какую степень Вы хотите возвести Ваше число:");
int numberPow = Convert.ToInt32(Console.ReadLine());
void printPow(int num, int numP)
{
	int result = 1;
	for (int i = 0; i < numP; i++)
	{
		result = result * num;
	}
	Console.WriteLine("Калькулятору кажется, что если число "+number+" возвести в степень "+numberPow+", получится число: "+result);
}
printPow(number, numberPow);