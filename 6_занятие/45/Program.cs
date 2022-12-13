// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.


void copyDefaultArray()
{
	int[] arrayOriginal = new int[7] { 3, 7, 9, 13, 23, 29, 97 };
	int[] arrayCopy = new int[arrayOriginal.Length];
	for (int i = 0; i < arrayOriginal.Length; i++)
	{
		arrayCopy[i] = arrayOriginal[i];
		Console.Write(" "+arrayCopy[i]);
	}
}
copyDefaultArray();