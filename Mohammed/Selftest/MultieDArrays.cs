using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mohammed.Selftest
{
    public class MultieDArrays
    {
        public static void Start()
        {
            int[][] array = Create2Array(10, 10);
            FillArray(array);
            PrintArray(array);
        }

        public static int[][] Create2Array(int height, int Width)
        {
            int[][] array = new int[height][];

            for (int i = 0; i < height; i++)
            {
                array[i] = new int[Width];
            }
            return array;
        }

        public static int[][] FillArray(int[][] array)
        {
            int number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = number++;
                }
            }
            return array;
        }

        public static void PrintArray(int[][]array)//double try
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0, 10}",array[i][j]);
                }
                Console.WriteLine( );
            }

        }



    }
}

