// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
	int[,] matrix = createRandomMatrix(n, m);
	writeMatrix(matrix);


	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		int temp = 0;
		for (int j = 0; j < matrix.GetLength(1) - 1; j++)
		{
			if (matrix[i, j] > matrix[i, j + 1])
			{
				temp = matrix[i, j + 1];
				matrix[i, j + 1] = matrix[i, j];
				matrix[i, j] = temp;
			}
		}
	}

	writeMatrix(matrix);

}

int n = 4;
int m = 4;
translateMatrix(n, m);