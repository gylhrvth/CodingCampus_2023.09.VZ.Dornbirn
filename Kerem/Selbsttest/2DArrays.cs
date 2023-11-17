using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Selbsttest
{
    internal class _2DArrays
    {
        public static void Start()
        {
            PrintArray(FillArray(CreateArray(10, 10)));
        }
        public static int[][] CreateArray(int height, int width)
        {
            int[][] arr2d = new int[height][];
            for (int i = 0; i < arr2d.Length; i++)
            {
                arr2d[i] = new int[width];
            }
            return arr2d;
        }
        public static int[][] FillArray(int[][] arr2D)
        {
            int fill = 0;
            for (int i = 0; i < arr2D.Length; i++)
            {
                for (int j = 0; j < arr2D[i].Length; j++)
                {
                    arr2D[i][j] = fill;
                    fill++;
                }
            }
            return arr2D;
        }
        public static int[][] PrintArray(int[][] arr2D)
        {
            for (int row = 0; row < arr2D.Length; row++)
            {
                for (int col = 0; col < arr2D[row].Length; col++)
                {
                    Console.Write("{0,-6}", arr2D[row][col]);
                }
                Console.WriteLine();
            }
            return arr2D;


        }
    }
}
