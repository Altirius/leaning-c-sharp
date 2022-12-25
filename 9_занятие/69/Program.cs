// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8


int sumNumberDigits(int N, int M)
{
	if (M > 1)
	{
		return N * sumNumberDigits(N, M - 1);
	}
	return N;
}


Console.Write(sumNumberDigits(2, 3));