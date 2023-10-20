using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace David.Week04
{
	public class _D
	{
		public static void Start2D()
		{
			int[][] arr = CreateArray2D(4, 6);

		}


		public static int[][] CreateArray2D(int rowNum, int colNum)
		{
            Random random = new Random();
			int[][] arr2D = new int[rowNum][];


            for (int row = 0; row < arr2D.Length; row++)
			{
				arr2D[row] = new int[colNum];
			}

			for (int r = 0; r < arr2D.Length; r++)
			{
				for (int c = 0; c < arr2D[r].Length; c++)
				{
					arr2D[r][c] = random.Next(10, 100);
				}
			}

			for (int r = 0; r < arr2D.Length; r++)
			{
				for (int c = 0; c < arr2D[r].Length; c++)
				{
					Console.Write(arr2D[r][c]+ " ");
				}
				Console.WriteLine();
			}
			return arr2D;
		}
	}
}

