// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void usersRandomNumbers()
{
	int result = 0;
	string? input=Console.ReadLine();
	while (input != "stop")
	{
		if (Convert.ToInt32(input) > 0)
		{
			result++;
		}
		input=Console.ReadLine();
	}
	Console.WriteLine("Воот столько положительных чисел Вы ввели:"+result);
}
usersRandomNumbers();