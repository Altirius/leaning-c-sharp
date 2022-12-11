// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
//  и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

void arrayMult()
{
	int[] arrayNumbers = new int[5] { 1, 3, 7, 9, 5 };
	int resultLength = arrayNumbers.Length % 2 == 0 ? arrayNumbers.Length / 2 : arrayNumbers.Length / 2 + 1;
	int[] arrayResult = new int[resultLength];

	for (int i = 0; i < arrayResult.Length; i++)
	{
		if (i == (arrayNumbers.Length - i - 1))
		{
			arrayResult[i] = arrayNumbers[i];
		}
		else
		{
			arrayResult[i] = arrayNumbers[i] * arrayNumbers[arrayNumbers.Length - i - 1];
		}
	}

	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		Console.Write(" " + arrayNumbers[i]);
	}
	Console.WriteLine();

	for (int i = 0; i < arrayResult.Length; i++)
	{
		Console.Write(" " + arrayResult[i]);
	}
}

arrayMult();