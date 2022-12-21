// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


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



void multMatrix(int n1, int m1, int n2, int m2)
{
	int[,] matrix1 = createRandomMatrix(n1, m1);
	writeMatrix(matrix1);

	int[,] matrix2 = createRandomMatrix(n2, m2);
	writeMatrix(matrix2);

	if (m1 != n2)
	{
		Console.WriteLine("Матрицы нельзя перемножить");
		return;
	}

	int temp = 0;
	int[,] result = new int[n1, m2];

	for (int i = 0; i < n1; i++)
	{
		for (int j = 0; j < m2; j++)
		{
			temp = 0;
			for (int k = 0; k < m1; k++)
			{
				temp += matrix1[i, k] * matrix2[k, j];
			}
			result[i, j] = temp;
		}
	}

	writeMatrix(result);
}

int n1 = 4;
int m1 = 4;
int n2 = 4;
int m2 = 4;
multMatrix(n1, m1, n2, m2);