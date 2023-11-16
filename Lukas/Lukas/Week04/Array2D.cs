using System;
namespace Lukas.Week04
{
    public class Array2D
    {
        public Array2D()
        {
        }

        public static void Start()
        {
            int[][] arr2d = new int[4][];

            for (int row = 0; row < arr2d.Length; row++)
            {
                arr2d[row] = new int[3];
            }


            Random random = new Random();

            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    arr2d[row][col] = random.Next(10, 100);
                }
            }

            foreach (int[] row in arr2d)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    Console.Write(arr2d[row][col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr2d[2][2]);

            Console.WriteLine("Sum of row with index 2 is " + SumRow(arr2d, 2));
            Console.WriteLine("Sum of col with index 2 is " + SumCol(arr2d, 2));
        }

        public static int SumRow(int[][] arr, int rowIndex)
        {
            int sum = 0;

            int[] myRow = arr[rowIndex];

            for(int i = 0; i < myRow.Length; i++)
            {
                sum += myRow[i];
            }
            return sum;
        }

        public static int SumCol(int[][] arr, int colIndex)
        {
            int sum = 0;

            for(int i = 0; i<arr.Length; i++)
            {
                sum += arr[i][colIndex];
            }
            return sum;
        }
    }
}

