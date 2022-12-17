// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void arrayRandomNumber2D()
{
	Random rnd = new Random();
	int[,] arrayNumbers = new int[10, 7];
	for (int i = 0; i < 10; i++)
		for (int j = 0; j < 7; j++)
			arrayNumbers[i, j] = rnd.Next(1, 99);

	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			Console.Write(arrayNumbers[i, j] + " ");
		}
		Console.WriteLine();
	}

}
arrayRandomNumber2D();