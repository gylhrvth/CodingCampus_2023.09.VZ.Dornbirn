using System;
namespace Gyula.Week05
{
	public class QueenProblem
	{
		public static int counter = 0;
		public static void Start(int size)
		{
			int[] table = new int[size];

			counter = 0;
			SolveQueen(0, table);
			Console.WriteLine("Anzahl Lösungen: " + counter);
		}

		public static void PrintTbl(int col, int[] tbl)
		{
			for (int i = 0; i < tbl.Length; i++)
			{
				for (int j = 0; j < tbl.Length; j++)
				{
					if (j <= col && tbl[j] == tbl.Length - 1 - i)
					{
                        Console.Write("Q ");
                    }
                    else
					{
                        Console.Write(". ");
                    }
                }
				Console.WriteLine();
			}
		}
		public static bool CheckPosition(int col, int[] tbl)
		{
			for (int i = col - 1; i >= 0; i--)
			{
				if (tbl[col] == tbl[i])
				{
					return false;
				}
				if (tbl[col] - tbl[i] == col - i)
				{
					return false;
				}
				if (tbl[col] + col == tbl[i] + i)
				{
					return false;
				}
			}
            return true;
        }

        public static void SolveQueen(int col, int[] tbl)
		{
			while (tbl[col] < tbl.Length)
			{
				if (CheckPosition(col, tbl))
				{
					if (col < tbl.Length - 1)
					{
						SolveQueen(col + 1, tbl);
					}
					else
					{
						Console.WriteLine("\nSolution:");
						PrintTbl(col, tbl);
						++counter;
					}
                }
                ++tbl[col];
			}
			tbl[col] = 0;
		}
	}
}

