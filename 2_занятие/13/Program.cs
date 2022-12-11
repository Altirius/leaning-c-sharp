// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите Ваше число сюда:");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1000)
{
	number = number / 10;
}
if ((number/100)==0 )
{
	Console.WriteLine("В Вашем числе нет 3 цифры. Найдите число побольше с:");
}
else
{
	Console.WriteLine("Ваша третья цифра:"+ (number%10));
}