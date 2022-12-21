// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void arrayNumber2D()
{
	Random rnd = new Random();
	int[,] arrayNumbers = new int[7, 7];
	double[] arraySA = new double[7];
	for (int i = 0; i < 7; i++)
	{
		arraySA[i] = 0;
		for (int j = 0; j < 7; j++)
		{
			arrayNumbers[i, j] = rnd.Next(1, 10);
			arraySA[i] = arraySA[i] + arrayNumbers[j, i];
		}
		arraySA[i] = Math.Round(arraySA[i] / 7, 2);
	}
	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			Console.Write(arrayNumbers[i, j] + " ");
		}
		Console.WriteLine();
	}
	Console.WriteLine("Среднее арифметическое каждого столбца:");
	for (int i = 0; i < 7; i++)
	{
		Console.Write(arraySA[i] + " ");
	}
}
arrayNumber2D();