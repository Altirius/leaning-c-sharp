// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5


void arraySearch1099()
{
	Random rnd = new Random();
	int[] arrayNumbers = new int[123];
	int a=0;
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		arrayNumbers[i]=rnd.Next(1, 123);
		Console.Write(" " + arrayNumbers[i]);
	}
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		if ((arrayNumbers[i]<99)&&(arrayNumbers[i]>10))
		{
			a++;			
		}
	}
	Console.WriteLine();
	Console.WriteLine(" В отрезке (10, 99) лежит: "+a+" значений");
}
arraySearch1099();