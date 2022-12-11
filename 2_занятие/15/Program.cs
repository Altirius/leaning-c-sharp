// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите нужную Вам цифру от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
	case 1:
		Console.WriteLine("Нет, день не выходной");
		break;
	case 2:
		Console.WriteLine("Нет, опять не выходной");
		break;
	case 3:
		Console.WriteLine("Нет, снова не выходной");
		break;
	case 4:
		Console.WriteLine("Нет, всё ещё не выходной");
		break;
	case 5:
		Console.WriteLine("Нет, но почти выходной");
		break;
	case 6:
		Console.WriteLine("Да, этот день выходной, почти у всех");
		break;
	case 7:
		Console.WriteLine("Да, этот день выходной");
		break;
		default:
		Console.WriteLine("Тут должна быть цифра в диапазоне от 1 до 7 :)");
		break;
}