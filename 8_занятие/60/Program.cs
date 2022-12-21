// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0, 0, 1)

// 45(1, 0, 0) 53(1, 0, 1)

int[,,] createUniq3DMatrix(int n, int m, int u)
{
	Random rnd = new Random();
	int[,,] matrix = new int[n, m, u];
	int value = 10 + rnd.Next(1, 10);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			for (int p = 0; p < u; p++)
			{
				matrix[i, j, p] = value;
				value += rnd.Next(1,10);
			}
		}
	}
	return matrix;
}

void write3DMatrix()
{
	int[,,] matrix =  createUniq3DMatrix(2, 2, 2);

	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			for (int p = 0; p < 2; p++)
			{
				Console.Write(matrix[i, j, p] + "(" + i + "," + j + "," + p + ") ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}

}

write3DMatrix();