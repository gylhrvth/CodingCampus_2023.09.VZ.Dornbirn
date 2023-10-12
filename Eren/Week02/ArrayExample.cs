using System;
namespace Gyula.Week03
{
	public class ArrayExample
	{
		public static Random rand = new Random();

		public static void StartArrayExample()
		{
			int[] fixArray = {5, 3, 12, -4, 0, 9, 6, 2};
			int[] myArray = CreateArray(10);

			Console.WriteLine("[{0}]", string.Join(", ", fixArray));
            Console.WriteLine("[{0}]", string.Join(", ", myArray));


			for (int i = 0; i < myArray.Length; i++)
			{
				int value = myArray[i];
				Console.WriteLine("myArray[{0}] = {1}", i, value);
			}

			foreach (int value in myArray)
			{
				Console.WriteLine("... {0}", value);
			}
        }

        public static int[] CreateArray(int size)
		{
			int[] arr = new int[size];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}

			return arr;
		}
    }
}

