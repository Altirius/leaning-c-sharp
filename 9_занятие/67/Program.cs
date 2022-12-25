// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int sumNumberDigits(int M)
{
	if (M > 0)
	{
		return M % 10 + sumNumberDigits(M / 10);
	}
	return 0;
}


Console.Write(sumNumberDigits(453));