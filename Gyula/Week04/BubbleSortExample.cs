using System;
using static Gyula.Week03.ArrayGenerator;
using static Gyula.Week03.ArrayTasks;

namespace Gyula.Week04
{
	public class BubbleSortExample
	{
		public static void Start()
		{
			int[] arr = CreateArrayRandom(20, 0, 1000);
			PrintArrayForEach(arr);

			BubbleSort(arr);
			Console.WriteLine("Sorted:");
            PrintArrayForEach(arr);

        }


        public static void BubbleSort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - i - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
            }
        }
    }
}

