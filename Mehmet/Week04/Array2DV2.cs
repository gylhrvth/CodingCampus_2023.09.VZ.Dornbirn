using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week04
{
    internal class Array2DV2
    {
        public static Random rand = new Random();

        public static void start()
        {

            int[][] arr2d = Create2DArrayRand(4, 7);
            Print2DArrayRand(arr2d);

            int[] sumRow = SumByRow(arr2d);
            Console.WriteLine(string.Join(" ", sumRow));

            int[] sumCol = SumByCol(arr2d);
            Console.WriteLine(string.Join(" ", sumCol));

        }       


        public static int[][] Create2DArrayRand(int row, int col)
        {
            int[][] arr = new int[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[col];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(0, 101);
                }
            }
            return arr;
        }

        public static void Print2DArrayRand(int[][] arr)
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


        public static int[] SumByCol(int[][]arr)
        {
            if (arr.Length == 0)
            {
                return new int[0] { };
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
