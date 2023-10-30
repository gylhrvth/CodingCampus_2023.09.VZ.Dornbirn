using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_Strukto
{
    internal class _2DArray
    {
        public static void Start()
        {
            PrintArray(FillArray(CreateArray(10, 10)));
        }

        public static int[][] CreateArray(int heigth, int widh)
        {
            int[][] arr2D = new int[heigth][];
            for (int i = 0; i < arr2D.Length; i++)
            {
                arr2D[i] = new int[widh];
            }
            return arr2D;
        }

        public static int[][] FillArray(int[][] arr2D)
        {
            int a = 0;
            for (int i = 0; i < arr2D.Length; i++)
            {
                for (int j = 0; j < arr2D[i].Length; j++)
                {
                    arr2D[i][j] = a;
                    a++;
                }
            }
            return arr2D;
        }

        public static int[][] PrintArray(int[][] arr2D)
        {
            for (int i = 0; i < arr2D.Length; i++)
            {
                for (int j = 0; j < arr2D[i].Length; j++)
                {
                    Console.Write("{0,-6}",arr2D[i][j]);
                }
                Console.WriteLine();
            }
            return arr2D;
        }





    }
}
