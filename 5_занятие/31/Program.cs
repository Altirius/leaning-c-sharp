// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//  сумма положительных чисел равна 29, сумма отрицательных равна -20.

Random rnd = new Random();
int[] arrayNumbers = new int[12];
for (int i = 0; i < 12; i++)
{
	arrayNumbers[i] = rnd.Next(-9, 9);
}
int sumMinus = 0;
int sumPlus = 0;
for (int i = 0; i < 12; i++)
{
	if (arrayNumbers[i] < 0)
	{
		sumMinus = sumMinus + arrayNumbers[i];
	}
	else
	{
		sumPlus = sumPlus + arrayNumbers[i];
	}
}
