// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int[,] createRandomMatrix(int n, int m)
{
	Random rnd = new Random();
	int[,] matrix = new int[n, m];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			matrix[i, j] = rnd.Next(1, 10);
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
	if (n != m)
	{
		Console.WriteLine("Нельзя заменить строки на столбцы");
		return;
	}

	int[,] matrix = createRandomMatrix(n, m);
	writeMatrix(matrix);

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < i; j++)
		{
			int temp = matrix[i, j];
			matrix[i, j] = matrix[j, i];
			matrix[j, i] = temp;
		}
	}
	writeMatrix(matrix);
}

int n = 4;
int m = 4;
translateMatrix(n, m);