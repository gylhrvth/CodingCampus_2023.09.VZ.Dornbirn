 using System;
namespace Gyula.Week02
{
	public class ArrayExample
	{
		public static void StartArrayExample()
		{
			int[] arr = {10, 12, 15, 66};

			Console.WriteLine(arr);
			for (int i = 0; i < arr.Length; ++i)
			{
				Console.WriteLine("{0}. = {1}", i, arr[i]);
			}
			Console.WriteLine("===================");

			arr[0] = 100;
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }


			Random rand = new Random();
			int[] arr2 = new int[10];
			for (int i = 0; i < arr2.Length; i++)
			{
				arr2[i] = rand.Next(10, 20);
			}

            Console.WriteLine("===================");
            for (int i = 0; i < arr2.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr2[i]);
            }



			Console.WriteLine(arr[4]);
        }
    }
}

