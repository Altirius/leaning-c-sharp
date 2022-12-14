// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void outputLeonardo ()
{
	int[] arrayLeonardo=new int[7];
	arrayLeonardo[0]=0;
	arrayLeonardo[1]=1;
	Console.Write("0 1");
	for (int i=2; i<7; i++)
	{
		arrayLeonardo[i]=arrayLeonardo[i-2]+arrayLeonardo[i-1];
		Console.Write(" "+arrayLeonardo[i]);
	}
}
outputLeonardo();