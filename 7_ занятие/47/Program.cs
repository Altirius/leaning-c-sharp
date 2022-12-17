// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​m = 3, n = 4.
// ​0,5 7 -2 -0,2
// ​1 -3,3 8 -9,9
// ​8 7,8 -7,1 9

void arrayRandomNumber2D()
{
	Random rnd = new Random();
	double[,] arrayNumbers = new double[5, 7];
	for (int i = 0; i < 5; i++)
		for (int j = 0; j < 7; j++) 
			arrayNumbers[i, j] = Math.Round(18*rnd.NextDouble() - 9, 1);
			
		

	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			Console.Write(arrayNumbers[i, j] + " ");
		}
		Console.WriteLine();
	}

}
arrayRandomNumber2D();