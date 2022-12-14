// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.


void withoutArray()
{
	Console.WriteLine("Введите длину 1 стороны предполагаемого треугольника:");
	int str1=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите длину 2 стороны предполагаемого треугольника:");
	int str2 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите длину 3 стороны предполагаемого треугольника:");
	int str3 = Convert.ToInt32(Console.ReadLine());
	if ((str1<(str2+str3))&&(str2 < (str1 + str3)) &&(str3 < (str1 + str2)))
	{
		Console.WriteLine("Поздравляю!Такой треугольник возможен :)");
	}
	else
	{
		Console.WriteLine("В нашей Вселенной треугольника с такими сторонами быть не может. Попробуйте с другими значениями с:");
	}
}
withoutArray();

void withArray ()
{
	Console.WriteLine("Вводите, пожалуйста, с помощью клавиши Enter ваши параметры:");
	int[] arrayT=new int[3];
	for (int i=0; i<3; i++)
	{
		arrayT[i]=Convert.ToInt32(Console.ReadLine());
	}
	if ((arrayT[0] < (arrayT[1] + arrayT[2])) && (arrayT[1] < (arrayT[0] + arrayT[2])) && (arrayT[2] < (arrayT[0] + arrayT[1])))
	{
		Console.WriteLine("Поздравляю!Такой треугольник возможен :)");
	}
	else
	{
		Console.WriteLine("В нашей Вселенной треугольника с такими сторонами быть не может. Попробуйте с другими значениями с:");
	}
}
withArray();