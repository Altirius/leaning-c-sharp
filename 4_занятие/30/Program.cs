// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void printArr010()
{
	Random rnd = new Random();
	int[] array = new int[8];
	for (int i = 0; i < 8; i++)
{
	array[i]=rnd.Next(0, 2);
}
for (int j = 0; j < 8; j++)
{
	Console.Write(array[j] + "; ");
}
}
printArr010();-