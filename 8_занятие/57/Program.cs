// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

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

	int[] dictionary = new int[10];

	for (int i = 0; i < 10; i++)
	{
		dictionary[i] = 0;
	}


	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			dictionary[matrix[i, j]]++;
		}
	}

	for (int i = 0; i < 10; i++)
	{
		if (dictionary[i] > 0)
		{
			if (dictionary[i] > 1)
			{
				Console.WriteLine(i + " встречается " + dictionary[i] + " раза");
			}
			else
			{
				Console.WriteLine(i + " встречается " + dictionary[i] + " раз");
			}

		}
	}

}

int n = 4;
int m = 4;
translateMatrix(n, m);