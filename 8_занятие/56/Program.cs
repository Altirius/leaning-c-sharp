// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] createRandomMatrix(int n, int m)
{
	Random rnd = new Random();
	int[,] matrix = new int[n, m];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			matrix[i, j] = rnd.Next(0, 9);
		}
	}
	return matrix;
}

void writeMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write(matrix[i, j] + " ");
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}

void getMinSumRow(int n, int m)
{
	int[,] matrix = createRandomMatrix(n, m);
	writeMatrix(matrix);

	int minRowIndex = 0;
	int minRowSum = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < matrix.GetLength(1) - 1; j++)
		{
			sum += matrix[i, j];
		}

		if (i == 0)
		{
			minRowSum = sum;
		} else if (sum < minRowSum)
		{
			minRowIndex = i;
			minRowSum = sum;
		}
	}

	Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minRowIndex + 1));
}

int n = 4;
int m = 4;
getMinSumRow(n, m);