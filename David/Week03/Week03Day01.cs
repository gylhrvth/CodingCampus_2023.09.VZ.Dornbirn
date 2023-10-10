using System;
namespace David.Week03
{
	public class Week03Day01
	{
		public static void StartWeek03Day01()
		{
			/*
			Random rand = new Random();
			int[] arr = new int[10];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(-50, 50);
			}

			for (int i = 0; i < arr.Length; ++i)
			{
				Console.WriteLine("{0}. = {1}", i, arr[i]);
			}
			Console.WriteLine("===================");
			Console.WriteLine("[{0}]", string.Join(", ", arr));
			*/

			int[] arr1 = CreateArrayAsc(5);
			PrintArray(arr1);

            int[] arr2 = CreateArrayDesc(5);
            PrintArray(arr2);

            int[] arr3 = CreateArrayRandom(5);
            PrintArray(arr3);

        }



        public static int[] CreateArrayAsc(int size)
		{
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine("{0}. = {1}", i, size[i]);
			}
		}

        public static int[] CreateArrayDesc(int size)
        {
            return null;
        }

        public static int[] CreateArrayRandom(int size)
        {
            return null;
        }


		public static void PrintArray(int[] arr)
		{
			
		}
    }
}

