// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void arrayMapInversion()
{
	Random rnd = new Random();
	int[] arrayNumbers = new int[9];
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		arrayNumbers[i] = rnd.Next(-10, 10);
		Console.Write(" " + arrayNumbers[i]);
	}
	Console.WriteLine();
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		arrayNumbers[i] = arrayNumbers[i] * -1;
		Console.Write(" " + arrayNumbers[i]);
	}

}
arrayMapInversion();