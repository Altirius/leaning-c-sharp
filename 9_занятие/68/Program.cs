// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3->A(m, n) = 9


int functionAckermann(int M, int N)
{
	if ((M > 0) && (N > 0))
	{
		return functionAckermann(M-1, functionAckermann(M, N-1));
	}
	else if ((M > 0) && (N == 0))
	{
		return functionAckermann(M-1, 1);
	}
	return N+1;
}


Console.Write(functionAckermann(2, 3));