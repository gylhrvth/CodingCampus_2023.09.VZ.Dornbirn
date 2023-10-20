using System;
namespace Mohammed.Week04
{
	public class Array2d
	{
		public static Random randomGenerator = new Random();

		public static void Start()
		{

			//PrintArray(CreateEmpatyarray(4, 4));
			int[][] arr2D = CreateFilled2DArray(2, 5);

			PrintArray(arr2D);
		}


		public static int[][] CreateEmpatyarray(int sizeRow, int sizeColumn)
		{
			
			int[][] arr2d = new int[sizeRow][];

			for (int i = 0; i < arr2d.Length; i++)
			{
				arr2d[i] = new int[sizeColumn];
			}
			return arr2d;
		}

		public static int[][] CreateFilled2DArray(int sizeRow, int sizeColumn)
		{
			int[][] arr2d = new int[sizeRow][];
			for (int i = 0; i<arr2d.Length; i++)
			{
				arr2d[i] = new int[sizeColumn];
				for (int j = 0; j < arr2d[i].Length; j++)
				{
					arr2d[i][j] = randomGenerator.Next(0, 1000);
				}
			}
			return arr2d;
		}


public static void PrintArray(int[][] arr)
		{
			foreach(int[] row in arr)
			{
				foreach(int value in row)
				{
					Console.Write(value + " ");
				}
				Console.WriteLine();
			}
		}


	}
}

