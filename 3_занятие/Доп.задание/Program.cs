// Доп.задание
// Написать метод для разворота массива, 
// не используя память под дополнительный массив

void revertArray(int[] arr, int length)
{
	double middle = length / 2;
	for (int i = 0; i < Math.Floor(middle); i++)
	{
		int temp = arr[i];
		arr[i] = arr[length - i - 1];
		arr[length - i - 1] = temp;
	}
}

int[] nums = new int[5] { 1, 2, 4, 3, 5 };
revertArray(nums, 5);
for (int i = 0; i < 5; i++)
{
	Console.Write(nums[i]);
}