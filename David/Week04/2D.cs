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

		public static int[][] CreatedArray2D(int rows, int cols)
		{
			int[] rowArr = new int[rows];

            Random random = new Random();

            for (int i = 0; i < rows.Length; i++)
			{
				rowArr[i] = random.Next(0, 100);
			}
			foreach (int RowElement in rowArr)
			{
				Console.WriteLine(RowElement + " ");
			}
			Console.WriteLine(rowArr);
			return rowArr;
			
		}
		
		
	}
}

