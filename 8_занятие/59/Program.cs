// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

void translateMatrix(int n, int m)
{
	if (n == 0 || m == 0)
		return;

	int[,] matrix = createRandomMatrix(n, m);
	writeMatrix(matrix);

	int[,] result = new int[n - 1, m - 1];
	int[] minIndexes = new int[2] { 0, 0 };

	// Непонятно что делать если у нас несколько ячеек с одним и тем же минимальным значением
	// Сделала так что первый найденный минимум считается минимальным

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i, j] < matrix[minIndexes[0], minIndexes[1]]) {
				minIndexes[0] = i;
				minIndexes[1] = j;
			}
		}
	}

	for (int i = 0; i < result.GetLength(0); i++)
	{
		for (int j = 0; j < result.GetLength(1); j++)
		{
			int column = minIndexes[0] > i ? i : i + 1;
			int row = minIndexes[1] > j ? j : j + 1;
			result[i, j] = matrix[column, row];
		}
	}

	writeMatrix(result);

}

int n = 4;
int m = 4;
translateMatrix(n, m);