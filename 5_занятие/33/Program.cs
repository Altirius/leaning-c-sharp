// Задача 33: Задайте массив.Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да


void arraySearch()
{
	Console.WriteLine("Введите Ваше число");
	int number = Convert.ToInt32(Console.ReadLine());
	Boolean flag = false;
	Random rnd = new Random();
	int[] arrayNumbers = new int[] {6, 7, 19, 345, 3 };
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		Console.Write(" "+arrayNumbers[i]);
	}
if (flag)
{
Console.WriteLine(" Да");
}
else
{
	Console.WriteLine(" Нетъ");
}
}
arraySearch();
//Надеюсь, что тут не нужен был рандомный массив :)