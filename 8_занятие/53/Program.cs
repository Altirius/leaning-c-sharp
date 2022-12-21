// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


int[,] arrayRandomCreate()
{
	Random rnd = new Random();
	int[,] arrayNumbers = new int[7, 7];
	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			arrayNumbers[i, j] = rnd.Next(1, 10);

		}
	}
	return arrayNumbers;
}
void arrayFirstLastReplace()
{
	int[,] arrayOriginal = arrayRandomCreate();
	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			Console.Write(" " + arrayOriginal[i, j]);
		}
	Console.WriteLine();
	}
	Console.WriteLine();
	for (int i = 0; i < 7; i++)
	{
		int temp = arrayOriginal[0, i];
		arrayOriginal[0, i] = arrayOriginal[6, i];
		arrayOriginal[6, i] = temp;
	}
	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			Console.Write(" " + arrayOriginal[i, j]);
		}
		Console.WriteLine();
	}
}
arrayFirstLastReplace();