using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace David.Week04
{
	public class _D
	{
		public static Random random = new Random();

        public static void Start2D()
		{
			int[][] arr = CreateArray2D(4, 6);
			PrintArray2D(arr);
		}


		public static int[][] CreateArray2D(int rowNum, int colNum)
		{
			int[][] arr2D = new int[rowNum][];

			for (int r = 0; r < arr2D.Length; r++)
			{
                arr2D[r] = new int[colNum];
                for (int c = 0; c < arr2D[r].Length; c++)
				{
					arr2D[r][c] = random.Next(10, 100);
				}
			}

			return arr2D;
        }

		public static void PrintArray2D(int[][] arr2D)
		{
            for (int r = 0; r < arr2D.Length; r++)
            {
                for (int c = 0; c < arr2D[r].Length; c++)
                {
                    Console.Write(arr2D[r][c] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintArray2DWithForeach(int[][] arr2D)
        {
            foreach (int[] row in arr2D)
            {
                foreach (int value in row)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

