using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week04
{
    internal class PascalDreieck
    {
        public static void start()
        {
            int[][] arr = CreateArray2D(10, 10);
            print2DArray(arr);


        }


        public static int[][] CreateArray2D(int row, int col)
        {
            int[][] arr = new int[row][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[col];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        arr[i][j] = 1;
                    }

                    else
                    {
                        arr[i][j] = arr[i - 1][j] + arr[i][j - 1];
                    }
                    
                }
               
            }
            return arr;
        }


        public static void print2DArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0,7}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }





    }
}
