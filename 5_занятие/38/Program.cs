// Задача 38: Задайте массив натуральных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void arrayRazn()
{
	Random rnd = new Random();
	int[] arrayNumbers = new int[10];
	int max=arrayNumbers[0];
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		arrayNumbers[i] = rnd.Next(0, 100);
		Console.Write(" " + arrayNumbers[i]);
	}
	for (int i=0; i<arrayNumbers.Length; i++)
	{
		if (arrayNumbers[i] > max)
		{
			max = arrayNumbers[i];
		}
	}
	int min=max;
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		if (arrayNumbers[i] < min)
		{
			min = arrayNumbers[i];
		}
	}
	Console.WriteLine();
	Console.WriteLine(" Разница между максимальным и минимальным значениями составляет вот столько: "+(max-min));
}
arrayRazn();