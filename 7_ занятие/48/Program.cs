// Задача 48: Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


void arrayNumber2D()
{
	Random rnd = new Random();
	int[,] arrayNumbers = new int[10, 7];
	for (int i = 0; i < 10; i++)
		for (int j = 0; j < 7; j++)
			arrayNumbers[i, j] = i+j;

	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			Console.Write(arrayNumbers[i, j] + " ");
		}
		Console.WriteLine();
	}

}
arrayNumber2D();