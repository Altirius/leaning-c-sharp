// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число:");
string number = Console.ReadLine();
int i=2;
string result="";
while (i<Convert.ToInt32(number)) {
	result=result+i;
	i=i+2;
}
Console.Write(" "+result);