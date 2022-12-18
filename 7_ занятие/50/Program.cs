// Задача 50.Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7->такого числа в массиве нет


void arrayNumber2D()
{
	Random rnd = new Random();
	int[,] arrayNumbers = new int[7, 7];
	for (int i = 0; i < 7; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			arrayNumbers[i, j] = rnd.Next(1, 10);

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
	Console.WriteLine("Введите позицию строки:");
	int pozArrayI = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите позицию столбца:");
	int pozArrayJ = Convert.ToInt32(Console.ReadLine());
	if ((pozArrayI >= 0) && (pozArrayI < 7) && (pozArrayJ >= 0) && (pozArrayJ < 7))
	{
		Console.WriteLine("Поздравляю, элемент с такими индексами есть. Любуйтесь :) "
		+ arrayNumbers[pozArrayI, pozArrayJ]);
	}
	else
	{
		Console.WriteLine("Тут такого элемента нет. Вы ошиблись массивом");
	}

}
arrayNumber2D();