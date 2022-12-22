// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

void writePascalTriangle(int rows)
{
	int value = 1;

	for (int i = 0; i < rows; i++)
	{
		for (int blank = 1; blank <= rows - i; blank++)
		{
			Console.Write(" ");
		}

		for (int j = 0; j <= i; j++)
		{
			if (j == 0 || i == 0)
			{
				value = 1;
			}
			else
			{
				value = value * (i - j + 1) / j;
			}

			Console.Write(value + " ");
		}
		Console.WriteLine();
	}
}

writePascalTriangle(6);