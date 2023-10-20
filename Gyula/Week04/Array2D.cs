using System;
namespace Gyula.Week04
{
	public class Array2D
	{
		public static Random generator = new Random();
		public static void Start()
		{
			int[][] arr2d = Create2DArray(5, 2);
			print2DArray(arr2d);

			int[] sumRow = SumByRow(arr2d);
			Console.WriteLine(string.Join(" ", sumRow));

            int[] sumCol = SumByCol(arr2d);
            Console.WriteLine(string.Join(" ", sumCol));
        }

        public static int[][] Create2DArray(int rows, int columns)
		{
			int[][] arr = new int[rows][];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new int[columns];
				for (int j = 0; j < arr[i].Length; j++)
				{
					arr[i][j] = generator.Next(0, 101);
				}
			}
			return arr;
		}

		public static void print2DArray(int[][] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write("{0,4}", arr[i][j]);
				}
				Console.WriteLine();
			}
		}

		public static int[] SumByRow(int[][] arr)
		{
			int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
					result[i] += arr[i][j];
                }
            }
            return result;
		}

        public static int[] SumByCol(int[][] arr)
		{
			if (arr.Length == 0)
			{
				return new int[] { };
			}

            int[] result = new int[arr[0].Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    result[j] += arr[i][j];
                }
            }
            return result;
        }

    }
}

