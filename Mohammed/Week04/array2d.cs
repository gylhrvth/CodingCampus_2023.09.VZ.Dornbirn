using System;
namespace Mohammed.Week04
{
	public class array2d
	{
		public static void Start()
		{

			PrintArray(CreateEmpatyarray(4, 4));
			
		}


		public static int[][] CreateEmpatyarray(int sizeM, int siteY)
		{
			
			int[][] arr2d = new int[sizeM][];

			for (int i = 0; i < arr2d.Length; i++)
			{
				arr2d[i] = new int[siteY];
			}
			return arr2d;
		}

		public static void PrintArray(int[][] arr)
		{
			foreach(int[] element in arr)
			{
				foreach(int element1 in element)
				{
					Console.Write(element1 + " ");
				}
				Console.WriteLine();
			}
		}


	}
}

