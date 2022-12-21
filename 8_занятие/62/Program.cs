// Задача 62.Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

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

void getSpiralMatrix(int n, int m)
{
	int[,] matrix = new int[n, m];

	int value = 0;
	int left = 0;
	int top = 0;
	int right = n;
	int bottom = m;

	for (int i = left; i < right; i++)
	{
		matrix[top, i] = value++;
	}
	right--; top++;
	for (int i = top; i < bottom; i++)
	{
		matrix[i, right] = value++;
	}
	bottom--;

	while ((bottom - top >= 0) && (right - left >= 0))
	{
		for (int i = right; i >= left; i--)
		{
			matrix[bottom, i] = value++;
		}
		bottom--;

		for (int i = bottom; i >= top; i--)
		{
			matrix[i, left] = value++;
		}
		left++;
		for (int i = left; i < right; i++)
		{
			matrix[top, i] = value++;
		}
		top++;
		for (int i = top; i < bottom; i++)
		{
			matrix[i, right] = value++;
		}
		right--;
	}

	writeMatrix(matrix);
}

int n = 4;
int m = 4;
getSpiralMatrix(n, m);