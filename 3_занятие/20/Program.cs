// Задача 20: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координату по Х точки 1");
int cAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y точки 1");
int cAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Х точки 2");
int cBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y точки 2");
int cBy = Convert.ToInt32(Console.ReadLine());
double DLN = Math.Sqrt(Math.Pow((cBy - cAy), 2) + Math.Pow((cBx - cAx), 2));
Console.WriteLine("Длина отрезка:" + Math.Round(DLN, 2));
//Почему-то выдает не 5.09, а округляет до 5.1. Подскажите, пожалуйста, почему так? :)