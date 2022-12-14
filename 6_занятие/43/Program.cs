// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

double[] readParams ()
{
	Console.WriteLine("Вводите, пожалуйста, с помощью клавиши Enter ваши параметры(b1, k1, b2, k2):");
	double[] arrayT = new double[4];
	for (int i = 0; i < 4; i++)
	{
		arrayT[i] = Convert.ToInt32(Console.ReadLine());
	}
	return arrayT;
}

void searchIntersection ()
{
	double[] arraySearch= readParams();
	double x=(arraySearch[0] - arraySearch[2]) / (arraySearch[3] - arraySearch[1]);
	double y=arraySearch[1]*x+arraySearch[0];
	Console.WriteLine("Ваши результаты: ("+x+"; "+y+")");
}
searchIntersection();