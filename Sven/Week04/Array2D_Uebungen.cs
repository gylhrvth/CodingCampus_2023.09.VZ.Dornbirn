using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week04
{
    internal class Array2D_Uebungen
    {
        

        public static void Start()
        {
            Console.WriteLine("Create 2DArray:");
            int[][] arr2d = Create2DArray();
            Print2DArray(arr2d);
            Console.WriteLine();

            Console.WriteLine("Sum Row 2D Array:");
            int[] sumRow = SumByRow(arr2d);
            Console.WriteLine(string.Join(" ", sumRow));
            Console.WriteLine();

            Console.WriteLine("Sum Col 2D Array:");
            int[] sumCol = SumByCol(arr2d);
            Console.WriteLine(string.Join(" ", sumCol));
            Console.WriteLine();



        }

        public static int [][] Create2DArray()
        {

            Random random = new Random();

            int[][] arr2d = new int[7][];
            for (int row = 0; row < arr2d.Length; row++)
            {
                arr2d[row] = new int[5];
            }

            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    arr2d[row][col] = random.Next(10, 100);
                }
            }
            return arr2d;
        }
        public static void Print2DArray(int[][] arr2d)
        {


            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    Console.Write(arr2d[row][col] + " ");
                }
                Console.WriteLine();

            }
        }

        public static int[] SumByRow(int[][] arr)
        {
            int[] result = new int[arr.Length];

            for ( int i = 0; i < arr.Length; i++)
            {
                for ( int j = 0; j < arr[i].Length; j++)
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
