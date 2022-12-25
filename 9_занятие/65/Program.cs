// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"

void writeNaturalNumber(int M, int N)
{
	Console.Write(M + ", ");
	if (M < N)
	{
		writeNaturalNumber(M+1, N);
	}
}


writeNaturalNumber(1, 5);