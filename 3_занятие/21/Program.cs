// Задача 21
// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координату по Х точки 1");
int cAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y точки 1");
int cAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Z точки 1");
int cAz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Х точки 2");
int cBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Y точки 2");
int cBy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по Z точки 2");
int cBz = Convert.ToInt32(Console.ReadLine());
double DLN = Math.Sqrt(Math.Pow((cBy - cAy), 2) + Math.Pow((cBx - cAx), 2)+ Math.Pow((cBz - cAz), 2));
Console.WriteLine("Длина отрезка:" + Math.Round(DLN, 2));