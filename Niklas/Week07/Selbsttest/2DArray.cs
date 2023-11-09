using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class _2DArray
    {
        public static void Start()
        {
            int[][] arr2d = CreateArray(10, 10);
            PrintArray(arr2d);
        }
        public static int[][] CreateArray(int rows, int columns)
        {
            int[][] arr = new int[rows][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[columns];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = i;
                }
            }

            return arr;
        }
        public static void PrintArray(int[][] array)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("  ");
                    if (i > 0)
                    {
                        Console.Write($"{i,1}");
                    }
                    else if (i < 1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($"{array[k][j],-4}");
                    k++;
                }
                k = 0;

                Console.WriteLine();
            }
        }

    }
}
