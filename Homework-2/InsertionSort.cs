using System;

class RecursiveInsertionSort
{
	static void InsertionSortRecursive(int[] array, int n)
	{
		if (n <= 1)
			return;

		InsertionSortRecursive(array, n - 1);

		int last = array[n - 1];
		int j = n - 2;

		while (j >= 0 && array[j] > last)
		{
			array[j + 1] = array[j];
			j--;
		}
		array[j + 1] = last;
	}

	static void Main()
	{
		int[] array = { 5, 3, 8, 6, 2 };
		Console.WriteLine("Original Array: " + string.Join(", ", array));

		InsertionSortRecursive(array, array.Length);

		Console.WriteLine("Sorted Array: " + string.Join(", ", array));
	}
}

