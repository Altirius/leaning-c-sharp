// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void writeNaturalNumber(int N)
{
	if (N > 1)
	{
		writeNaturalNumber(N - 1);
	}
	Console.Write(N+", ");
}


writeNaturalNumber(5);