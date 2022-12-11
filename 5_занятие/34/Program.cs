// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void arrayShowCN()
{
	Random rnd = new Random();
	int[] arrayNumbers = new int[10];
	int a = 0;
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		arrayNumbers[i] = rnd.Next(100, 999);
		Console.Write(" " + arrayNumbers[i]);
	}
	for (int i=0; i<arrayNumbers.Length; i++)
	{
		if ((arrayNumbers[i]%2)==0)
		{
			a++;
		}
	}
	Console.WriteLine();
	Console.WriteLine("Количество черных числе в массиве: "+a);
}
arrayShowCN();