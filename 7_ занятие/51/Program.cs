// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void arrayNumber2D()
{
	int sum=0;
	Random rnd = new Random();
	int[,] arrayNumbers = new int[7, 7];
	for (int i = 0; i < 7; i++)
		for (int j = 0; j < 7; j++){
			arrayNumbers[i, j] = rnd.Next(1, 10);
			if (i==j)
			{
				sum=sum+arrayNumbers[i, j];
			}
		}
	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			Console.Write(arrayNumbers[i, j] + " ");
		}
		Console.WriteLine();
	}
	Console.WriteLine("Сумма элементов главной диагонали:" + sum);

}
arrayNumber2D();