using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbsttest1
{
    internal class _2DArrays
    {

        public static void Start()
        {
            PrintArray(FillArray(Create2DArray(10, 10)));

        }



        public static int[][] Create2DArray(int height, int width)
        {
            int[][] arr2D = new int[height][];

            for (int i = 0; i < arr2D.Length; i++)
            {
                arr2D[i] = new int[width];
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
    }
}
