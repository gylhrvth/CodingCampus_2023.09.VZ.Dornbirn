using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Selbsttest
{
    internal class twoDArray
    {
        public static void Start()
        {
            Console.WriteLine(Create2DArr(10, 10));

            Fill2DArr(Create2DArr(10, 10));

            Print2DArr(Fill2DArr(Create2DArr(10, 10)));

        }

        public static int[][] Create2DArr(int row, int col)
        {
            int[][] arr = new int[col][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[row];
            }
            return arr;
        }
        public static int[][] Fill2DArr(int[][] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = count++;
                }
            }
            return arr;
        }
        public static void Print2DArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j],-10}");
                }
                Console.WriteLine();
            }
        }


    }
}
