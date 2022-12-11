// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0


void arraySumN()
{
	Random rnd = new Random();
	int[] arrayNumbers = new int[10];
	int a = 0;
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		arrayNumbers[i] = rnd.Next(-10, 10);
		Console.Write(" " + arrayNumbers[i]);
	}
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		if ((i%2)==1)
		{
		a+=arrayNumbers[i];
		}
	}
	Console.WriteLine();
	Console.WriteLine(" Сумма чисел на нечетных позициях: "+a);
}
arraySumN();